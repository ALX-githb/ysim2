// MissingScriptFinder.cs
// Editor-only diagnostic tool: scans every prefab and scene in the project and
// reports which GameObjects have missing MonoBehaviour script references.
//
// Usage in the Unity Editor:
//   Tools -> Find Missing Scripts -> Scan Prefabs
//   Tools -> Find Missing Scripts -> Scan Open Scene
//   Tools -> Find Missing Scripts -> Scan All Scenes In Build Settings
//
// All results are printed to the Console. Each entry includes the asset path,
// the GameObject hierarchy path, and the broken script GUID (so you can grep
// the project for it if the original .cs.meta is still around somewhere).

#if UNITY_EDITOR
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class MissingScriptFinder
{
    private const string MenuRoot = "Tools/Find Missing Scripts/";

    [MenuItem(MenuRoot + "Scan Prefabs")]
    public static void ScanPrefabs()
    {
        var guids = AssetDatabase.FindAssets("t:Prefab");
        int total = 0;
        int prefabsWithMissing = 0;
        var sb = new StringBuilder();
        sb.AppendLine("[MissingScriptFinder] Scanning " + guids.Length + " prefab(s)...");

        for (int i = 0; i < guids.Length; i++)
        {
            string path = AssetDatabase.GUIDToAssetPath(guids[i]);
            if (EditorUtility.DisplayCancelableProgressBar("Scanning prefabs",
                path, (float)i / guids.Length))
            {
                EditorUtility.ClearProgressBar();
                Debug.Log(sb.ToString());
                return;
            }

            var go = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (go == null) continue;

            int count = CountMissingOnHierarchy(go.transform, path, sb);
            if (count > 0)
            {
                prefabsWithMissing++;
                total += count;
            }
        }

        EditorUtility.ClearProgressBar();
        sb.AppendLine();
        sb.AppendLine("[MissingScriptFinder] Done. " + total + " missing script(s) across "
            + prefabsWithMissing + " prefab(s).");
        Debug.Log(sb.ToString());
    }

    [MenuItem(MenuRoot + "Scan Open Scene")]
    public static void ScanOpenScene()
    {
        var sb = new StringBuilder();
        var scene = SceneManager.GetActiveScene();
        sb.AppendLine("[MissingScriptFinder] Scanning open scene: " + scene.path);
        int total = ScanSceneRoots(scene, sb);
        sb.AppendLine();
        sb.AppendLine("[MissingScriptFinder] Done. " + total + " missing script(s) in this scene.");
        Debug.Log(sb.ToString());
    }

    [MenuItem(MenuRoot + "Scan All Scenes In Build Settings")]
    public static void ScanAllBuildScenes()
    {
        var sb = new StringBuilder();
        int total = 0;
        var current = EditorSceneManager.GetActiveScene().path;

        foreach (var s in EditorBuildSettings.scenes)
        {
            if (!s.enabled || string.IsNullOrEmpty(s.path)) continue;
            var scene = EditorSceneManager.OpenScene(s.path, OpenSceneMode.Single);
            sb.AppendLine();
            sb.AppendLine("[MissingScriptFinder] Scene: " + s.path);
            total += ScanSceneRoots(scene, sb);
        }

        if (!string.IsNullOrEmpty(current))
        {
            EditorSceneManager.OpenScene(current, OpenSceneMode.Single);
        }

        sb.AppendLine();
        sb.AppendLine("[MissingScriptFinder] Done. " + total + " missing script(s) across all scenes.");
        Debug.Log(sb.ToString());
    }

    [MenuItem(MenuRoot + "Scan Raw Assets For Dead GUIDs (Slow)")]
    public static void ScanRawAssetFiles()
    {
        // Walks .prefab/.unity/.asset files as text and reports any m_Script reference
        // whose GUID doesn't resolve to a MonoScript in the project.
        var roots = new[] { "Assets" };
        var extensions = new HashSet<string> { ".prefab", ".unity", ".asset" };
        var rx = new Regex(@"m_Script:\s*\{fileID:\s*-?\d+,\s*guid:\s*([a-f0-9]{32}),\s*type:\s*3\}",
            RegexOptions.Compiled);

        var sb = new StringBuilder();
        sb.AppendLine("[MissingScriptFinder] Raw scan starting...");
        int dead = 0;
        int filesWithDead = 0;

        var allFiles = new List<string>();
        foreach (var root in roots)
        {
            if (!Directory.Exists(root)) continue;
            foreach (var f in Directory.GetFiles(root, "*", SearchOption.AllDirectories))
            {
                if (extensions.Contains(Path.GetExtension(f).ToLowerInvariant()))
                    allFiles.Add(f);
            }
        }

        var deadCache = new Dictionary<string, bool>();

        for (int i = 0; i < allFiles.Count; i++)
        {
            var f = allFiles[i];
            if (EditorUtility.DisplayCancelableProgressBar("Raw scanning",
                f, (float)i / allFiles.Count))
            {
                EditorUtility.ClearProgressBar();
                Debug.Log(sb.ToString());
                return;
            }

            string text;
            try { text = File.ReadAllText(f); }
            catch { continue; }

            var matches = rx.Matches(text);
            bool fileHasDead = false;
            foreach (Match m in matches)
            {
                string guid = m.Groups[1].Value;
                if (!deadCache.TryGetValue(guid, out bool isDead))
                {
                    string p = AssetDatabase.GUIDToAssetPath(guid);
                    isDead = string.IsNullOrEmpty(p)
                        || AssetDatabase.LoadAssetAtPath<MonoScript>(p) == null;
                    deadCache[guid] = isDead;
                }
                if (isDead)
                {
                    if (!fileHasDead) { sb.AppendLine(); sb.AppendLine("FILE: " + f); fileHasDead = true; }
                    sb.AppendLine("    dead guid: " + guid);
                    dead++;
                }
            }
            if (fileHasDead) filesWithDead++;
        }

        EditorUtility.ClearProgressBar();
        sb.AppendLine();
        sb.AppendLine("[MissingScriptFinder] Raw scan done. " + dead + " dead reference(s) across "
            + filesWithDead + " file(s).");
        Debug.Log(sb.ToString());
    }

    // --- helpers -------------------------------------------------------

    private static int ScanSceneRoots(Scene scene, StringBuilder sb)
    {
        int total = 0;
        foreach (var root in scene.GetRootGameObjects())
        {
            total += CountMissingOnHierarchy(root.transform, scene.path, sb);
        }
        return total;
    }

    private static int CountMissingOnHierarchy(Transform t, string assetPath, StringBuilder sb)
    {
        int total = 0;
        var components = t.GetComponents<Component>();
        for (int i = 0; i < components.Length; i++)
        {
            if (components[i] == null)
            {
                sb.AppendLine("MISSING in " + assetPath + "  ->  " + GetHierarchyPath(t)
                    + "  (component slot " + i + ")");
                total++;
            }
        }
        for (int i = 0; i < t.childCount; i++)
        {
            total += CountMissingOnHierarchy(t.GetChild(i), assetPath, sb);
        }
        return total;
    }

    private static string GetHierarchyPath(Transform t)
    {
        if (t.parent == null) return t.name;
        return GetHierarchyPath(t.parent) + "/" + t.name;
    }
}
#endif
