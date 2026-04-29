using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

// =====================================================================
// Global exception guard that prevents NullReferenceException spam from
// killing the game on iOS. When a script throws repeatedly in Update(),
// this auto-disables that specific component so the rest of the scene
// keeps running.
//
// Hooked automatically before the first scene loads via
// RuntimeInitializeOnLoadMethod — no need to add it to any scene.
// =====================================================================
internal static class RuntimeExceptionGuard
{
    private const int DisableThreshold = 3;
    private static readonly Dictionary<string, int> _hitCount = new Dictionary<string, int>();
    private static readonly Regex _scriptRegex = new Regex(
        @"(?:at\s+|^)([A-Za-z_][A-Za-z0-9_]*)\.(Update|LateUpdate|FixedUpdate|Start|Awake)\s*\(",
        RegexOptions.Compiled | RegexOptions.Multiline);

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Install()
    {
        Application.logMessageReceived -= OnLog;
        Application.logMessageReceived += OnLog;
    }

    private static void OnLog(string condition, string stackTrace, LogType type)
    {
        if (type != LogType.Exception) return;
        if (string.IsNullOrEmpty(stackTrace)) return;

        // Catch NullReferenceException and UnassignedReferenceException —
        // both usually indicate unassigned inspector refs in a specific script.
        if (condition == null) return;
        if (!condition.Contains("NullReferenceException") &&
            !condition.Contains("UnassignedReferenceException") &&
            !condition.Contains("IndexOutOfRangeException")) return;

        Match m = _scriptRegex.Match(stackTrace);
        if (!m.Success) return;

        string key = m.Groups[1].Value + "." + m.Groups[2].Value;
        if (!_hitCount.TryGetValue(key, out int count)) count = 0;
        count++;
        _hitCount[key] = count;

        if (count == DisableThreshold)
        {
            TryDisableComponentsOfType(m.Groups[1].Value, key);
        }
    }

    private static void TryDisableComponentsOfType(string typeName, string key)
    {
        // Find the type by short name across all loaded assemblies.
        System.Type targetType = null;
        foreach (var asm in System.AppDomain.CurrentDomain.GetAssemblies())
        {
            foreach (var t in asm.GetTypes())
            {
                if (t.Name == typeName && typeof(MonoBehaviour).IsAssignableFrom(t))
                {
                    targetType = t;
                    break;
                }
            }
            if (targetType != null) break;
        }

        if (targetType == null) return;

        Object[] all = Object.FindObjectsByType(targetType, FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        int disabled = 0;
        foreach (var obj in all)
        {
            if (obj is Behaviour b && b.enabled)
            {
                b.enabled = false;
                disabled++;
            }
        }

        if (disabled > 0)
        {
            Debug.LogWarning($"[RuntimeExceptionGuard] Disabled {disabled} instance(s) of '{typeName}' after {DisableThreshold} repeated exceptions in {key}. Check unassigned inspector references.");
        }
    }
}
