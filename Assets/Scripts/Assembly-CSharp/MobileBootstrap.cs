using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// Runs before ANY scene loads. Sets aggressive quality limits on mobile
/// so that Unity's scene deserializer loads assets at reduced quality,
/// preventing out-of-memory (jetsam) kills on iOS.
/// </summary>
public static class MobileBootstrap
{
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void ApplyMobileBudget()
	{
		if (!Application.isMobilePlatform) return;

		// Halve all texture resolutions — single biggest memory saving
		QualitySettings.masterTextureLimit = 1;

		// Disable expensive rendering features
		QualitySettings.antiAliasing = 0;
		QualitySettings.shadows = ShadowQuality.Disable;
		QualitySettings.skinWeights = SkinWeights.TwoBones;
		QualitySettings.lodBias = 0.5f;
		QualitySettings.pixelLightCount = 1;
		QualitySettings.realtimeReflectionProbes = false;
		QualitySettings.billboardsFaceCameraPosition = false;
		QualitySettings.softParticles = false;
		QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 30;

		// Limit shader complexity
		Shader.globalMaximumLOD = 100;

		Debug.Log("[MobileBootstrap] Applied mobile quality budget. RAM: " +
			SystemInfo.systemMemorySize + " MB, VRAM: " + SystemInfo.graphicsMemorySize + " MB");
	}
}
