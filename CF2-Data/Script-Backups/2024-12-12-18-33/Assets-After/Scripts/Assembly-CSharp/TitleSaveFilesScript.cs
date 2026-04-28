using System;
using UnityEngine;

public class TitleSaveFilesScript : MonoBehaviour
{
	public InputManagerScript InputManager;

	public TitleSaveDataScript[] SaveDatas;

	public TitleMenuScript Menu;

	public Transform Highlight;

	public bool Show;

	public int ID = 1;

	private void Start()
	{
		base.transform.localPosition = new Vector3(1050f, base.transform.localPosition.y, base.transform.localPosition.z);
		UpdateHighlight();
	}

	private void Update()
	{
		if (!Show)
		{
			base.transform.localPosition = new Vector3(Mathf.Lerp(base.transform.localPosition.x, 1050f, Time.deltaTime * 10f), base.transform.localPosition.y, base.transform.localPosition.z);
			return;
		}
		base.transform.localPosition = new Vector3(Mathf.Lerp(base.transform.localPosition.x, 0f, Time.deltaTime * 10f), base.transform.localPosition.y, base.transform.localPosition.z);
		if (InputManager.TappedDown)
		{
			ID++;
			if (ID > 3)
			{
				ID = 1;
			}
			UpdateHighlight();
		}
		if (InputManager.TappedUp)
		{
			ID--;
			if (ID < 1)
			{
				ID = 3;
			}
			UpdateHighlight();
		}
		if (ControlFreak2.CF2Input.GetButtonDown("A"))
		{
			if (SaveDatas[ID].EmptyFile.activeInHierarchy)
			{
				SaveFile saveFile = new SaveFile(ID);
				SaveFileData data = saveFile.Data;
				data.playerData.kills = 0;
				data.schoolData.schoolAtmosphere = 1f;
				data.playerData.alerts = 0;
				data.dateData.week = 1;
				data.dateData.weekday = DayOfWeek.Sunday;
				data.playerData.reputation = 0f;
				data.clubData.club = ClubType.None;
				saveFile.Save();
				SaveDatas[ID].Start();
			}
			else
			{
				SaveFileGlobals.CurrentSaveFile = ID;
				Menu.FadeOut = true;
				Menu.Fading = true;
			}
		}
		else if (ControlFreak2.CF2Input.GetButtonDown("X"))
		{
			SaveFile.Delete(ID);
			SaveDatas[ID].Start();
		}
	}

	private void UpdateHighlight()
	{
		Highlight.localPosition = new Vector3(0f, 700f - 350f * (float)ID, 0f);
	}
}
