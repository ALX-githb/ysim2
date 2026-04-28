using UnityEngine;

public class ConvoManagerScript : MonoBehaviour
{
	public StudentManagerScript SM;

	public int ID;

	public string[] FemaleCombatAnims;

	public string[] MaleCombatAnims;

	public int CombatAnimID;

	public float CheckTimer;

	public bool Confirmed;

	public void CheckMe(int StudentID)
	{
		if (StudentID > 1 && StudentID < 14)
		{
			for (ID = 2; ID < 14; ID++)
			{
				if (ID != StudentID && SM.Students[ID] != null)
				{
					if (SM.Students[ID].Routine && (double)Vector3.Distance(SM.Students[ID].transform.position, SM.Students[StudentID].transform.position) < 2.5)
					{
						SM.Students[StudentID].Alone = false;
						break;
					}
					SM.Students[StudentID].Alone = true;
				}
			}
			return;
		}
		switch (StudentID)
		{
		case 17:
			if (SM.Students[18].Routine && (double)Vector3.Distance(SM.Students[17].transform.position, SM.Students[18].transform.position) < 1.4)
			{
				SM.Students[17].Alone = false;
			}
			else
			{
				SM.Students[17].Alone = true;
			}
			return;
		case 18:
			if (SM.Students[17].Routine && (double)Vector3.Distance(SM.Students[18].transform.position, SM.Students[17].transform.position) < 1.4)
			{
				SM.Students[18].Alone = false;
			}
			else
			{
				SM.Students[18].Alone = true;
			}
			return;
		case 21:
		case 22:
		case 23:
		case 24:
		case 25:
			for (ID = 21; ID < 26; ID++)
			{
				if (ID != StudentID && SM.Students[ID] != null)
				{
					if (SM.Students[ID].Routine && (double)Vector3.Distance(SM.Students[ID].transform.position, SM.Students[StudentID].transform.position) < 2.5)
					{
						SM.Students[StudentID].Alone = false;
						break;
					}
					SM.Students[StudentID].Alone = true;
				}
			}
			return;
		}
		if (StudentID > 25 && StudentID < 32)
		{
			for (ID = 26; ID < 32; ID++)
			{
				if (ID != StudentID && SM.Students[ID] != null)
				{
					if (SM.Students[ID].Routine && (double)Vector3.Distance(SM.Students[ID].transform.position, SM.Students[StudentID].transform.position) < 2.5)
					{
						SM.Students[StudentID].Alone = false;
						break;
					}
					SM.Students[StudentID].Alone = true;
				}
			}
			return;
		}
		switch (StudentID)
		{
		case 33:
			if (SM.Students[34].Routine && (double)Vector3.Distance(SM.Students[33].transform.position, SM.Students[34].transform.position) < 1.4)
			{
				SM.Students[33].Alone = false;
			}
			else
			{
				SM.Students[33].Alone = true;
			}
			return;
		case 34:
			if (SM.Students[33].Routine && (double)Vector3.Distance(SM.Students[34].transform.position, SM.Students[33].transform.position) < 1.4)
			{
				SM.Students[34].Alone = false;
			}
			else
			{
				SM.Students[34].Alone = true;
			}
			return;
		case 56:
		case 57:
		case 58:
		case 59:
		case 60:
			for (ID = 56; ID < 61; ID++)
			{
				if (ID != StudentID && SM.Students[ID] != null)
				{
					if (SM.Students[ID].Routine && Vector3.Distance(SM.Students[ID].transform.position, SM.Students[StudentID].transform.position) < 2.66666f)
					{
						SM.Students[StudentID].Alone = false;
						break;
					}
					SM.Students[StudentID].Alone = true;
				}
			}
			return;
		}
		if (StudentID > 75 && StudentID < 81)
		{
			for (ID = 76; ID < 81; ID++)
			{
				if (ID != StudentID && SM.Students[ID] != null)
				{
					if ((double)Vector3.Distance(SM.Students[ID].transform.position, SM.Students[StudentID].transform.position) < 2.5)
					{
						SM.Students[StudentID].TrueAlone = false;
						if (SM.Students[ID].Routine)
						{
							SM.Students[StudentID].Alone = false;
							break;
						}
						SM.Students[StudentID].Alone = true;
					}
					else
					{
						SM.Students[StudentID].TrueAlone = true;
						SM.Students[StudentID].Alone = true;
					}
				}
			}
			return;
		}
		if (StudentID <= 80 || StudentID >= 86)
		{
			return;
		}
		for (ID = 81; ID < 86; ID++)
		{
			if (ID != StudentID && SM.Students[ID] != null)
			{
				if (SM.Students[ID].Routine && (double)Vector3.Distance(SM.Students[ID].transform.position, SM.Students[StudentID].transform.position) < 2.5)
				{
					SM.Students[StudentID].Alone = false;
					break;
				}
				SM.Students[StudentID].Alone = true;
			}
		}
	}

	public void MartialArtsCheck()
	{
		CheckTimer += Time.deltaTime;
		if ((CheckTimer > 1f || Confirmed) && SM.Students[22] != null && SM.Students[24] != null && SM.Students[22].Routine && SM.Students[24].Routine && SM.Students[22].DistanceToDestination < 0.1f && SM.Students[24].DistanceToDestination < 0.1f)
		{
			Confirmed = true;
			CombatAnimID++;
			if (CombatAnimID > 2)
			{
				CombatAnimID = 1;
			}
			SM.Students[22].ClubAnim = MaleCombatAnims[CombatAnimID];
			SM.Students[24].ClubAnim = FemaleCombatAnims[CombatAnimID];
			SM.Students[22].GetNewAnimation = false;
			SM.Students[24].GetNewAnimation = false;
		}
	}

	public void LateUpdate()
	{
		CheckTimer = Mathf.MoveTowards(CheckTimer, 0f, Time.deltaTime);
		if (Confirmed && (SM.Students[22].DistanceToPlayer < 1.5f || SM.Students[24].DistanceToPlayer < 1.5f || SM.Students[22].Talking || SM.Students[24].Talking || SM.Students[22].Distracted || SM.Students[24].Distracted))
		{
			SM.Students[22].Subtitle.UpdateLabel(SubtitleType.IntrusionReaction, 2, 5f);
			SM.Students[22].ClubAnim = "idle_20";
			SM.Students[24].ClubAnim = "f02_idle_20";
			Confirmed = false;
		}
	}
}
