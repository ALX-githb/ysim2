using UnityEngine;

public class SettingsScript : MonoBehaviour
{
	public QualityManagerScript QualityManager;

	public InputManagerScript InputManager;

	public PauseScreenScript PauseScreen;

	public PromptBarScript PromptBar;

	public UILabel DrawDistanceLabel;

	public UILabel PostAliasingLabel;

	public UILabel LowDetailLabel;

	public UILabel AliasingLabel;

	public UILabel OutlinesLabel;

	public UILabel ParticleLabel;

	public UILabel BloomLabel;

	public UILabel FogLabel;

	public UILabel ShadowsLabel;

	public UILabel FarAnimsLabel;

	public UILabel FPSCapLabel;

	public UILabel SensitivityLabel;

	public int SelectionLimit = 2;

	public int Selected = 1;

	public Transform CloudSystem;

	public Transform Highlight;

	public GameObject Background;

	private void Start()
	{
		LowerAllSettings();
	}

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Space))
		{
			OptionGlobals.DepthOfField = !OptionGlobals.DepthOfField;
			QualityManager.ToggleExperiment();
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.R))
		{
			OptionGlobals.RimLight = !OptionGlobals.RimLight;
			QualityManager.RimLight();
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.B))
		{
			ToggleBackground();
		}
		if (InputManager.TappedUp)
		{
			Selected--;
			UpdateHighlight();
		}
		else if (InputManager.TappedDown)
		{
			Selected++;
			UpdateHighlight();
		}

		switch (Selected)
		{
			case 1:
			    if (InputManager.TappedRight)
			    {
				    OptionGlobals.ParticleCount++;
				    QualityManager.UpdateParticles();
				    UpdateText();
			    }
			    else if (InputManager.TappedLeft)
			    {
				    OptionGlobals.ParticleCount--;
				    QualityManager.UpdateParticles();
				    UpdateText();
			    }
				break;
			case 2:
			    if (InputManager.TappedRight || InputManager.TappedLeft)
			    {
				    OptionGlobals.DisableOutlines = !OptionGlobals.DisableOutlines;
				    UpdateText();
				    QualityManager.UpdateOutlines();
			    }
				break;
			case 3:
			    if (InputManager.TappedRight)
			{
				if (QualitySettings.antiAliasing > 0)
				{
					QualitySettings.antiAliasing *= 2;
				}
				else
				{
					QualitySettings.antiAliasing = 2;
				}
				UpdateText();
			}
			else if (InputManager.TappedLeft)
			{
				if (QualitySettings.antiAliasing > 0)
				{
					QualitySettings.antiAliasing /= 2;
				}
				else
				{
					QualitySettings.antiAliasing = 0;
				}
				UpdateText();
			}
			break;
			case 4:
			    if (InputManager.TappedRight || InputManager.TappedLeft)
			{
				OptionGlobals.DisablePostAliasing = !OptionGlobals.DisablePostAliasing;
				UpdateText();
				QualityManager.UpdatePostAliasing();
			}
			break;
			case 5:
			    if (InputManager.TappedRight || InputManager.TappedLeft)
			{
				OptionGlobals.DisableBloom = !OptionGlobals.DisableBloom;
				UpdateText();
				QualityManager.UpdateBloom();
			}
			break;
			case 6:
			    if (InputManager.TappedRight)
			{
				OptionGlobals.LowDetailStudents--;
				QualityManager.UpdateLowDetailStudents();
				UpdateText();
			}
			else if (InputManager.TappedLeft)
			{
				OptionGlobals.LowDetailStudents++;
				QualityManager.UpdateLowDetailStudents();
				UpdateText();
			}
			break;
			case 7:
			    if (InputManager.TappedRight)
			{
				OptionGlobals.DrawDistance += 10;
				QualityManager.UpdateDrawDistance();
				UpdateText();
			}
			else if (InputManager.TappedLeft)
			{
				OptionGlobals.DrawDistance -= 10;
				QualityManager.UpdateDrawDistance();
				UpdateText();
			}
			break;
			case 8:
			    if (InputManager.TappedRight || InputManager.TappedLeft)
			{
				OptionGlobals.Fog = !OptionGlobals.Fog;
				UpdateText();
				QualityManager.UpdateFog();
			}
			break;
			case 9:
			    if (InputManager.TappedRight || InputManager.TappedLeft)
			{
				OptionGlobals.DisableShadows = !OptionGlobals.DisableShadows;
				UpdateText();
				QualityManager.UpdateShadows();
			}
			break;
			case 10:
			    if (InputManager.TappedRight || InputManager.TappedLeft)
			{
				OptionGlobals.DisableFarAnimations = !OptionGlobals.DisableFarAnimations;
				UpdateText();
				QualityManager.UpdateAnims();
			}
			break;
			case 11:
			    if (InputManager.TappedRight)
			{
				OptionGlobals.FPSIndex++;
			}
			else if (InputManager.TappedLeft)
			{
				OptionGlobals.FPSIndex--;
			}
			QualityManager.UpdateFPSIndex();
			UpdateText();
			break;
			case 12:
			    if (InputManager.TappedRight)
			{
				if (OptionGlobals.Sensitivity < 10)
				{
					OptionGlobals.Sensitivity++;
				}
			}
			else if (InputManager.TappedLeft && OptionGlobals.Sensitivity > 1)
			{
				OptionGlobals.Sensitivity--;
			}
			UpdateText();
			break;
		}
		
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.L))
		{
			LowerAllSettings();
		}
		if (ControlFreak2.CF2Input.GetButtonDown("B"))
		{
			PromptBar.ClearButtons();
			PromptBar.Label[0].text = "Accept";
			PromptBar.Label[1].text = "Exit";
			PromptBar.Label[4].text = "Choose";
			PromptBar.UpdateButtons();
			PauseScreen.ScreenBlur.enabled = true;
			PauseScreen.MainMenu.SetActive(true);
			PauseScreen.Sideways = false;
			PauseScreen.PressedB = true;
			base.gameObject.SetActive(false);
		}
	}

	public void UpdateText()
	{
		switch (OptionGlobals.ParticleCount)
		{
			case 3:
			    ParticleLabel.text = "High";
				break;
			case 2:
			    ParticleLabel.text = "Low";
				break;
			case 1:
			    ParticleLabel.text = "None";
				break;
		}
		FPSCapLabel.text = QualityManagerScript.FPSStrings[OptionGlobals.FPSIndex];
		OutlinesLabel.text = ((!OptionGlobals.DisableOutlines) ? "On" : "Off");
		AliasingLabel.text = QualitySettings.antiAliasing + "x";
		PostAliasingLabel.text = ((!OptionGlobals.DisablePostAliasing) ? "On" : "Off");
		BloomLabel.text = ((!OptionGlobals.DisableBloom) ? "On" : "Off");
		LowDetailLabel.text = ((OptionGlobals.LowDetailStudents != 0) ? (OptionGlobals.LowDetailStudents * 10 + "m") : "Off");
		DrawDistanceLabel.text = OptionGlobals.DrawDistance + "m";
		FogLabel.text = ((!OptionGlobals.Fog) ? "Off" : "On");
		ShadowsLabel.text = ((!OptionGlobals.DisableShadows) ? "On" : "Off");
		FarAnimsLabel.text = ((!OptionGlobals.DisableFarAnimations) ? "On" : "Off");
		SensitivityLabel.text = string.Empty + OptionGlobals.Sensitivity;
	}

	private void UpdateHighlight()
	{
		if (Selected == 0)
		{
			Selected = SelectionLimit;
		}
		else if (Selected > SelectionLimit)
		{
			Selected = 1;
		}
		Highlight.localPosition = new Vector3(Highlight.localPosition.x, 445f - 65f * (float)Selected, Highlight.localPosition.z);
	}

	public void ToggleBackground()
	{
		if (!Background.activeInHierarchy)
		{
			OptionGlobals.DrawDistanceLimit = 500;
			OptionGlobals.DrawDistance = 500;
			CloudSystem.localScale = new Vector3(1000f, 1000f, 1000f);
			QualityManager.UpdateDrawDistance();
			Background.SetActive(true);
		}
		else
		{
			OptionGlobals.DrawDistanceLimit = 350;
			OptionGlobals.DrawDistance = 350;
			CloudSystem.localScale = new Vector3(500f, 500f, 500f);
			QualityManager.UpdateDrawDistance();
			Background.SetActive(false);
		}
	}

	public void LowerAllSettings()
	{
		OptionGlobals.ParticleCount = 1;
		OptionGlobals.DisableOutlines = true;
		QualitySettings.antiAliasing = 0;
		OptionGlobals.DisablePostAliasing = true;
		OptionGlobals.DisableBloom = true;
		OptionGlobals.LowDetailStudents = 1;
		OptionGlobals.DrawDistance = 50;
		OptionGlobals.DisableShadows = true;
		OptionGlobals.DisableFarAnimations = true;
		OptionGlobals.RimLight = false;
		OptionGlobals.DepthOfField = false;
		if (QualityManager != null)
		{
			QualityManager.UpdateFog();
			QualityManager.UpdateAnims();
			QualityManager.UpdateBloom();
			QualityManager.UpdateFPSIndex();
			QualityManager.UpdateShadows();
			QualityManager.UpdateParticles();
			QualityManager.UpdatePostAliasing();
			QualityManager.UpdateDrawDistance();
			QualityManager.UpdateLowDetailStudents();
			QualityManager.UpdateOutlines();
		}
		UpdateText();
	}
}
