using UnityEngine;

public class TaskManagerScript : MonoBehaviour
{
	public StudentManagerScript StudentManager;

	public YandereScript Yandere;

	public GameObject[] TaskObjects;

	public PromptScript[] Prompts;

	private void Start()
	{
		UpdateTaskStatus();
	}

	private void Update()
	{
		if (TaskGlobals.GetTaskStatus(6) == 1 && Prompts[6].Circle[3].fillAmount == 0f)
		{
			if (StudentManager.Students[6] != null)
			{
				StudentManager.Students[6].TaskPhase = 5;
			}
			TaskGlobals.SetTaskStatus(6, 2);
			Object.Destroy(TaskObjects[6]);
		}
		if (TaskGlobals.GetTaskStatus(15) == 1 && Prompts[15].Circle[3] != null && Prompts[15].Circle[3].fillAmount == 0f)
		{
			if (StudentManager.Students[15] != null)
			{
				StudentManager.Students[15].TaskPhase = 5;
			}
			TaskGlobals.SetTaskStatus(15, 2);
			Object.Destroy(TaskObjects[15]);
		}
		if (TaskGlobals.GetTaskStatus(33) == 1 && Prompts[33].Circle[3] != null && Prompts[33].Circle[3].fillAmount == 0f)
		{
			if (StudentManager.Students[33] != null)
			{
				StudentManager.Students[33].TaskPhase = 5;
			}
			TaskGlobals.SetTaskStatus(33, 2);
			Object.Destroy(TaskObjects[33]);
		}
		if (Yandere.Talking)
		{
			return;
		}
		if (TaskGlobals.GetTaskStatus(81) == 1)
		{
			if (Yandere.Inventory.Cigs)
			{
				if (StudentManager.Students[81] != null)
				{
					StudentManager.Students[81].TaskPhase = 5;
				}
				TaskGlobals.SetTaskStatus(81, 2);
			}
		}
		else if (TaskGlobals.GetTaskStatus(81) == 2 && !Yandere.Inventory.Cigs)
		{
			if (StudentManager.Students[81] != null)
			{
				StudentManager.Students[81].TaskPhase = 4;
			}
			TaskGlobals.SetTaskStatus(81, 1);
		}
	}

	public void UpdateTaskStatus()
	{
		if (TaskGlobals.GetTaskStatus(6) == 1)
		{
			if (StudentManager.Students[6] != null)
			{
				if (StudentManager.Students[6].TaskPhase == 0)
				{
					StudentManager.Students[6].TaskPhase = 4;
				}
				TaskObjects[6].SetActive(true);
			}
		}
		else if (TaskObjects[6] != null)
		{
			TaskObjects[6].SetActive(false);
		}
		if (TaskGlobals.GetTaskStatus(7) == 1 && StudentManager.Students[7] != null && StudentManager.Students[7].TaskPhase == 0)
		{
			StudentManager.Students[7].TaskPhase = 4;
		}
		if (TaskGlobals.GetTaskStatus(13) == 1 && StudentManager.Students[13] != null)
		{
			StudentManager.Students[13].TaskPhase = 4;
			for (int i = 1; i < 26; i++)
			{
				if (TaskGlobals.GetKittenPhoto(i))
				{
					StudentManager.Students[13].TaskPhase = 5;
				}
			}
		}
		if (TaskGlobals.GetTaskStatus(14) == 1)
		{
			if (StudentManager.Students[14] != null && StudentManager.Students[14].TaskPhase == 0)
			{
				StudentManager.Students[14].TaskPhase = 4;
			}
		}
		else if (TaskGlobals.GetTaskStatus(14) == 2 && StudentManager.Students[14] != null)
		{
			StudentManager.Students[14].TaskPhase = 5;
		}
		if (TaskGlobals.GetTaskStatus(15) == 1)
		{
			if (StudentManager.Students[15] != null)
			{
				if (StudentManager.Students[15].TaskPhase == 0)
				{
					StudentManager.Students[15].TaskPhase = 4;
				}
				TaskObjects[15].SetActive(true);
			}
		}
		else if (TaskObjects[15] != null)
		{
			TaskObjects[15].SetActive(false);
		}
		if (TaskGlobals.GetTaskStatus(81) == 3)
		{
		}
		if (TaskGlobals.GetTaskStatus(33) == 1)
		{
			if (StudentManager.Students[33] != null)
			{
				if (StudentManager.Students[33].TaskPhase == 0)
				{
					StudentManager.Students[33].TaskPhase = 4;
				}
				TaskObjects[33].SetActive(true);
			}
		}
		else if (TaskObjects[33] != null)
		{
			TaskObjects[33].SetActive(false);
		}
	}
}
