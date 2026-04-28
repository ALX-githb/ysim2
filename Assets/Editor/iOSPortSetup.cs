// iOSPortSetup.cs
// One-click application of recommended Player Settings + Build Settings for an
// iOS port of this project. Uses Unity's PlayerSettings API (safe) rather than
// hand-editing ProjectSettings.asset (fragile YAML).
//
// Menu:  Tools -> iOS -> Apply Optimal iOS Player Settings
// Menu:  Tools -> iOS -> Switch Platform To iOS
// Menu:  Tools -> iOS -> Print Current iOS Settings
//
// Re-run safely. Each setter is idempotent.

#if UNITY_EDITOR
using System.Linq;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Rendering;

public static class iOSPortSetup
{
    private const string MenuRoot = "Tools/iOS/";

    // Edit these to match your Apple developer account if/when you build.
    private const string DefaultBundleIdentifier = "com.yandere.simulator";
    private const string DefaultProductName       = "Yandere Simulator";
    private const string DefaultCompanyName       = "YandereDev";
    private const string DefaultCameraUsage       = "This game uses the camera for in-game photo features.";
    private const string DefaultMicrophoneUsage   = "This game uses the microphone for in-game voice features.";
    private const string DefaultLocationUsage     = ""; // empty means feature disabled
    private const string DefaultMinIOSVersion     = "13.0";

    [MenuItem(MenuRoot + "Switch Platform To iOS")]
    public static void SwitchPlatform()
    {
        if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.iOS)
        {
            Debug.Log("[iOSPortSetup] Already on iOS platform.");
            return;
        }
        Debug.Log("[iOSPortSetup] Switching to iOS platform... (long re-import follows).");
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.iOS, BuildTarget.iOS);
    }

    [MenuItem(MenuRoot + "Apply Optimal iOS Player Settings")]
    public static void Apply()
    {
        var ios = NamedBuildTarget.iOS;

        // ---------- Identification ----------
        if (string.IsNullOrEmpty(PlayerSettings.applicationIdentifier)
            || PlayerSettings.applicationIdentifier.StartsWith("com.DefaultCompany"))
        {
            PlayerSettings.applicationIdentifier = DefaultBundleIdentifier;
        }
        if (string.IsNullOrEmpty(PlayerSettings.productName)
            || PlayerSettings.productName == "DefaultCompany")
        {
            PlayerSettings.productName = DefaultProductName;
        }
        if (string.IsNullOrEmpty(PlayerSettings.companyName)
            || PlayerSettings.companyName == "DefaultCompany")
        {
            PlayerSettings.companyName = DefaultCompanyName;
        }
        if (string.IsNullOrEmpty(PlayerSettings.bundleVersion))
        {
            PlayerSettings.bundleVersion = "0.1.0";
        }
        PlayerSettings.iOS.buildNumber = string.IsNullOrEmpty(PlayerSettings.iOS.buildNumber)
            ? "1" : PlayerSettings.iOS.buildNumber;

        // ---------- Scripting backend & architecture ----------
        // iOS forces IL2CPP, but set it explicitly so the project file records it.
        PlayerSettings.SetScriptingBackend(ios, ScriptingImplementation.IL2CPP);
        PlayerSettings.SetArchitecture(ios, 1); // 0 = ARMv7, 1 = ARM64, 2 = Universal. iOS requires ARM64.
        PlayerSettings.SetApiCompatibilityLevel(ios, ApiCompatibilityLevel.NET_Standard);

        // Release build for shipping; switch to Debug temporarily if you need Xcode breakpoints.
        PlayerSettings.SetIl2CppCompilerConfiguration(ios, Il2CppCompilerConfiguration.Master);

        // Stripping. "Low" is the safest for a project with this much reflection
        // (JsonFx, VRM10, UniGLTF). link.xml is the real defense; this just adds margin.
        PlayerSettings.SetManagedStrippingLevel(ios, ManagedStrippingLevel.Low);

        // ---------- Graphics ----------
        // Metal only. iOS no longer supports OpenGL ES.
        PlayerSettings.SetGraphicsAPIs(BuildTarget.iOS, new[] { GraphicsDeviceType.Metal });
        PlayerSettings.MTRendering = true;
        PlayerSettings.gpuSkinning = true;
        PlayerSettings.colorSpace  = ColorSpace.Linear; // A16 GPU is more than capable; better PBR fidelity.

        // ---------- iOS-specific ----------
        PlayerSettings.iOS.targetOSVersionString  = DefaultMinIOSVersion;
        PlayerSettings.iOS.targetDevice           = iOSTargetDevice.iPhoneAndiPad;
        PlayerSettings.iOS.sdkVersion             = iOSSdkVersion.DeviceSDK;
        PlayerSettings.iOS.appleEnableAutomaticSigning = true;
        PlayerSettings.iOS.requiresPersistentWiFi      = false;
        PlayerSettings.iOS.statusBarStyle              = iOSStatusBarStyle.Default;
        PlayerSettings.iOS.allowHTTPDownload           = false; // App Transport Security on
        PlayerSettings.iOS.scriptCallOptimization      = ScriptCallOptimizationLevel.SlowAndSafe;

        // Required usage descriptions. App Store rejects the app if any used capability
        // lacks a string; harmless to set even when not used.
        if (string.IsNullOrEmpty(PlayerSettings.iOS.cameraUsageDescription))
            PlayerSettings.iOS.cameraUsageDescription = DefaultCameraUsage;
        if (string.IsNullOrEmpty(PlayerSettings.iOS.microphoneUsageDescription))
            PlayerSettings.iOS.microphoneUsageDescription = DefaultMicrophoneUsage;
        if (string.IsNullOrEmpty(PlayerSettings.iOS.locationUsageDescription))
            PlayerSettings.iOS.locationUsageDescription = DefaultLocationUsage;

        // Orientation: the school scene is designed landscape.
        PlayerSettings.defaultInterfaceOrientation = UIOrientation.LandscapeLeft;
        PlayerSettings.allowedAutorotateToLandscapeLeft  = true;
        PlayerSettings.allowedAutorotateToLandscapeRight = true;
        PlayerSettings.allowedAutorotateToPortrait       = false;
        PlayerSettings.allowedAutorotateToPortraitUpsideDown = false;

        // ---------- Memory / asset stripping ----------
        PlayerSettings.stripUnusedMeshComponents = true;
        PlayerSettings.bakeCollisionMeshes       = true;

        // ---------- Quality settings (best-effort) ----------
        // Leave the user's Quality Settings alone — touching them via API is brittle.
        // Just log a recommendation.
        Debug.Log("[iOSPortSetup] Recommendation: in Edit -> Project Settings -> Quality, "
                + "create a 'Mobile' tier with shadows = Hard Only, shadow distance <= 30, "
                + "anti-aliasing = 2x, V Sync = Don't Sync, and set it as the default for iOS.");

        // ---------- Build target ----------
        EditorUserBuildSettings.iOSXcodeBuildConfig = XcodeBuildConfig.Release;
        EditorUserBuildSettings.development         = false;
        EditorUserBuildSettings.allowDebugging      = false;
        EditorUserBuildSettings.connectProfiler     = false;

        AssetDatabase.SaveAssets();

        Debug.Log("[iOSPortSetup] Optimal iOS Player Settings applied.\n"
                + "Bundle ID:        " + PlayerSettings.applicationIdentifier + "\n"
                + "Product Name:     " + PlayerSettings.productName + "\n"
                + "Min iOS Version:  " + PlayerSettings.iOS.targetOSVersionString + "\n"
                + "Scripting:        IL2CPP / ARM64 / .NET Standard\n"
                + "IL2CPP Config:    Master (release)\n"
                + "Stripping:        Low (link.xml protects reflection)\n"
                + "Graphics API:     Metal\n"
                + "Color Space:      Linear\n"
                + "Orientation:      Landscape only\n"
                + "Camera Usage:     " + PlayerSettings.iOS.cameraUsageDescription + "\n"
                + "Microphone Usage: " + PlayerSettings.iOS.microphoneUsageDescription);

        Debug.LogWarning("[iOSPortSetup] Manual follow-ups:\n"
                + "  1. Set your real Apple Team ID in Player Settings -> iOS -> Identification -> Signing.\n"
                + "  2. Replace Bundle Identifier with one tied to your provisioning profile.\n"
                + "  3. Run Tools -> Find Missing Scripts -> Scan Prefabs and fix any results before building.\n"
                + "  4. The Assets/Resources folder has ~10K entries; consider moving non-essential assets\n"
                + "     out of Resources into Addressables to reduce iOS startup time and memory.\n"
                + "  5. Test on-device EARLY. iOS-only crashes (reflection / shader / Metal) won't appear\n"
                + "     in the Editor.");
    }

    [MenuItem(MenuRoot + "Print Current iOS Settings")]
    public static void Print()
    {
        var ios = NamedBuildTarget.iOS;
        var apis = PlayerSettings.GetGraphicsAPIs(BuildTarget.iOS);
        Debug.Log(
            "[iOSPortSetup] Current iOS settings\n"
            + "Bundle ID:        " + PlayerSettings.applicationIdentifier + "\n"
            + "Product Name:     " + PlayerSettings.productName + "\n"
            + "Company Name:     " + PlayerSettings.companyName + "\n"
            + "Bundle Version:   " + PlayerSettings.bundleVersion + "\n"
            + "Build Number:     " + PlayerSettings.iOS.buildNumber + "\n"
            + "Min iOS Version:  " + PlayerSettings.iOS.targetOSVersionString + "\n"
            + "Target Device:    " + PlayerSettings.iOS.targetDevice + "\n"
            + "Scripting:        " + PlayerSettings.GetScriptingBackend(ios) + "\n"
            + "API Level:        " + PlayerSettings.GetApiCompatibilityLevel(ios) + "\n"
            + "IL2CPP Config:    " + PlayerSettings.GetIl2CppCompilerConfiguration(ios) + "\n"
            + "Stripping:        " + PlayerSettings.GetManagedStrippingLevel(ios) + "\n"
            + "Architecture:     " + PlayerSettings.GetArchitecture(ios) + " (1 = ARM64)\n"
            + "Graphics APIs:    " + string.Join(", ", apis.Select(a => a.ToString())) + "\n"
            + "Color Space:      " + PlayerSettings.colorSpace + "\n"
            + "MT Rendering:     " + PlayerSettings.MTRendering + "\n"
            + "GPU Skinning:     " + PlayerSettings.gpuSkinning + "\n"
            + "Camera Usage:     " + (PlayerSettings.iOS.cameraUsageDescription ?? "<none>") + "\n"
            + "Microphone Usage: " + (PlayerSettings.iOS.microphoneUsageDescription ?? "<none>"));
    }
}
#endif
