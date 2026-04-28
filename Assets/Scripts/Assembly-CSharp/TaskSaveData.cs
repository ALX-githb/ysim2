using System;
using System.Collections.Generic;

[Serializable]
public class TaskSaveData
{
	public IntHashSet kittenPhoto = new IntHashSet();

	public IntAndIntDictionary taskStatus = new IntAndIntDictionary();

	public static TaskSaveData ReadFromGlobals()
	{
		TaskSaveData taskSaveData = new TaskSaveData();
		int[] array = TaskGlobals.KeysOfKittenPhoto();
		foreach (int num in array)
		{
			if (TaskGlobals.GetKittenPhoto(num))
			{
				taskSaveData.kittenPhoto.Add(num);
			}
		}
		int[] array2 = TaskGlobals.KeysOfTaskStatus();
		foreach (int num2 in array2)
		{
			taskSaveData.taskStatus.Add(num2, TaskGlobals.GetTaskStatus(num2));
		}
		return taskSaveData;
	}

	public static void WriteToGlobals(TaskSaveData data)
	{
		foreach (int item in data.kittenPhoto)
		{
			TaskGlobals.SetKittenPhoto(item, true);
		}
		foreach (KeyValuePair<int, int> item2 in data.taskStatus)
		{
			TaskGlobals.SetTaskStatus(item2.Key, item2.Value);
		}
	}
}
