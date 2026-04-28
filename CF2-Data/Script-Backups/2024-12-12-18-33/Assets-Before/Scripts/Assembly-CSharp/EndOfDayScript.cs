using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfDayScript : MonoBehaviour
{
	public SecuritySystemScript SecuritySystem;

	public StudentManagerScript StudentManager;

	public WeaponManagerScript WeaponManager;

	public ClubManagerScript ClubManager;

	public HeartbrokenScript Heartbroken;

	public IncineratorScript Incinerator;

	public WoodChipperScript WoodChipper;

	public ReputationScript Reputation;

	public DumpsterLidScript Dumpster;

	public CounselorScript Counselor;

	public WeaponScript MurderWeapon;

	public TranqCaseScript TranqCase;

	public YandereScript Yandere;

	public RagdollScript Corpse;

	public PoliceScript Police;

	public JsonScript JSON;

	public GardenHoleScript[] GardenHoles;

	public GameObject MainCamera;

	public UISprite EndOfDayDarkness;

	public UILabel Label;

	public bool PreviouslyActivated;

	public bool PoliceArrived;

	public bool ClubClosed;

	public bool ClubKicked;

	public bool ErectFence;

	public bool GameOver;

	public bool Darken;

	public int FragileTarget;

	public int DeadPerps;

	public int Arrests;

	public int Corpses;

	public int Victims;

	public int Weapons;

	public int Phase = 1;

	public int WeaponID;

	public int ArrestID;

	public int ClubID;

	public int ID;

	public string[] ClubNames;

	public int[] VictimArray;

	public ClubType[] ClubArray;

	private SaveFile saveFile;

	public void Start()
	{
		EndOfDayDarkness.color = new Color(EndOfDayDarkness.color.r, EndOfDayDarkness.color.g, EndOfDayDarkness.color.b, 1f);
		PreviouslyActivated = true;
		GetComponent<AudioSource>().volume = 0f;
		UpdateScene();
	}

	private void Update()
	{
		if (EndOfDayDarkness.color.a == 0f && Input.GetButtonDown("A"))
		{
			Darken = true;
		}
		if (Darken)
		{
			EndOfDayDarkness.color = new Color(EndOfDayDarkness.color.r, EndOfDayDarkness.color.g, EndOfDayDarkness.color.b, Mathf.MoveTowards(EndOfDayDarkness.color.a, 1f, Time.deltaTime));
			if (EndOfDayDarkness.color.a == 1f)
			{
				if (!GameOver)
				{
					Darken = false;
					UpdateScene();
				}
				else
				{
					Heartbroken.transform.parent.transform.parent = null;
					Heartbroken.transform.parent.gameObject.SetActive(true);
					Heartbroken.Noticed = false;
					Heartbroken.Arrested = true;
					MainCamera.SetActive(false);
					base.gameObject.SetActive(false);
					Time.timeScale = 1f;
				}
			}
		}
		else
		{
			EndOfDayDarkness.color = new Color(EndOfDayDarkness.color.r, EndOfDayDarkness.color.g, EndOfDayDarkness.color.b, Mathf.MoveTowards(EndOfDayDarkness.color.a, 0f, Time.deltaTime));
		}
		AudioSource component = GetComponent<AudioSource>();
		component.volume = Mathf.MoveTowards(component.volume, 1f, Time.deltaTime);
	}

	public void UpdateScene()
	{
		if (!PoliceArrived)
		{
			return;
		}
		if (Input.GetKeyDown(KeyCode.Backspace))
		{
			Finish();
		}
		if (Phase == 1)
		{
			if (Police.PoisonScene)
			{
				Label.text = "The police and the paramedics arrive at school.";
				Phase = 103;
				return;
			}
			if (Police.DrownScene)
			{
				Label.text = "The police arrive at school.";
				Phase = 104;
				return;
			}
			if (Police.ElectroScene)
			{
				Label.text = "The police arrive at school.";
				Phase = 105;
				return;
			}
			if (Police.MurderSuicideScene)
			{
				Label.text = "The police arrive at school, and discover what appears to be the scene of a murder-suicide.";
				Phase++;
				return;
			}
			Label.text = "The police arrive at school.";
			if (Police.SuicideScene)
			{
				Phase = 102;
			}
			else
			{
				Phase++;
			}
		}
		else if (Phase == 2)
		{
			if (Police.Corpses == 0)
			{
				if (!Police.PoisonScene && !Police.SuicideScene)
				{
					Label.text = "The police are unable to locate any corpses on school grounds.";
					Phase++;
				}
				else
				{
					Label.text = "The police are unable to locate any other corpses on school grounds.";
					Phase++;
				}
				return;
			}
			List<string> list = new List<string>();
			RagdollScript[] corpseList = Police.CorpseList;
			foreach (RagdollScript ragdollScript in corpseList)
			{
				if (ragdollScript != null)
				{
					VictimArray[Corpses] = ragdollScript.Student.StudentID;
					list.Add(ragdollScript.Student.Name);
					Corpses++;
				}
			}
			list.Sort();
			string text = "The police discover the corpse" + ((list.Count != 1) ? "s" : string.Empty) + " of ";
			if (list.Count == 1)
			{
				Label.text = text + list[0] + ".";
			}
			else if (list.Count == 2)
			{
				Label.text = text + list[0] + " and " + list[1] + ".";
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 0; j < list.Count - 1; j++)
				{
					stringBuilder.Append(list[j] + ", ");
				}
				stringBuilder.Append("and " + list[list.Count - 1] + ".");
				Label.text = text + stringBuilder.ToString();
			}
			Phase++;
		}
		else if (Phase == 3)
		{
			WeaponManager.CheckWeapons();
			if (WeaponManager.MurderWeapons == 0)
			{
				if (Weapons == 0)
				{
					Label.text = "The police are unable to locate any murder weapons.";
					Phase += 2;
				}
				else
				{
					Phase += 2;
					UpdateScene();
				}
				return;
			}
			MurderWeapon = null;
			for (ID = 0; ID < WeaponManager.Weapons.Length; ID++)
			{
				if (MurderWeapon == null)
				{
					WeaponScript weaponScript = WeaponManager.Weapons[ID];
					if (weaponScript != null && weaponScript.Blood.enabled)
					{
						weaponScript.Blood.enabled = false;
						MurderWeapon = weaponScript;
						WeaponID = ID;
					}
				}
			}
			List<string> list2 = new List<string>();
			for (ID = 0; ID < MurderWeapon.Victims.Length; ID++)
			{
				if (MurderWeapon.Victims[ID])
				{
					list2.Add(JSON.Students[ID].Name);
				}
			}
			list2.Sort();
			Victims = list2.Count;
			string text2 = MurderWeapon.Name;
			string text3 = ((text2[text2.Length - 1] == 's') ? (text2.ToLower() + " that are") : ("a " + text2.ToLower() + " that is"));
			string text4 = "The police discover " + text3 + " stained with the blood of ";
			if (list2.Count == 1)
			{
				Label.text = text4 + list2[0] + ".";
			}
			else if (list2.Count == 2)
			{
				Label.text = text4 + list2[0] + " and " + list2[1] + ".";
			}
			else
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				for (int k = 0; k < list2.Count - 1; k++)
				{
					stringBuilder2.Append(list2[k] + ", ");
				}
				stringBuilder2.Append("and " + list2[list2.Count - 1] + ".");
				Label.text = text4 + stringBuilder2.ToString();
			}
			Weapons++;
			Phase++;
		}
		else if (Phase == 4)
		{
			if (MurderWeapon.FingerprintID == 0)
			{
				Label.text = "The police find no fingerprints on the weapon.";
				Phase = 3;
			}
			else if (MurderWeapon.FingerprintID == 100)
			{
				Label.text = "The police find Yandere-chan's fingerprints on the weapon.";
				Phase = 100;
			}
			else
			{
				Label.text = "The police find the fingerprints of " + JSON.Students[WeaponManager.Weapons[WeaponID].FingerprintID].Name + " on the weapon.";
				Phase = 101;
			}
		}
		else if (Phase == 5)
		{
			if (SchoolGlobals.HighSecurity)
			{
				if (!SecuritySystem.Evidence)
				{
					Label.text = "The police investigate the security camera recordings, but cannot find anything incriminating in the footage.";
					Phase++;
				}
				else if (!SecuritySystem.Masked)
				{
					Label.text = "The police investigate the security camera recordings, and find incriminating footage of Yandere-chan.";
					Phase = 100;
				}
				else
				{
					Label.text = "The police investigate the security camera recordings, and find footage of a suspicious masked person.";
					Police.MaskReported = true;
					Phase = 100;
				}
			}
			else
			{
				Phase++;
				UpdateScene();
			}
		}
		else if (Phase == 6)
		{
			if (Yandere.Sanity > 33.33333f)
			{
				if (Yandere.Bloodiness > 0f || (Yandere.Gloved && Yandere.Gloves.Blood.enabled))
				{
					if (Arrests == 0)
					{
						Label.text = "The police notice that Yandere-chan's clothing is bloody. They confirm that the blood is not hers. Yandere-chan is unable to convince the police that she did not commit murder.";
						Phase = 100;
						return;
					}
					Label.text = "The police notice that Yandere-chan's clothing is bloody. They confirm that the blood is not hers. Yandere-chan is able to convince the police that she was splashed with blood while witnessing a murder.";
					if (!TranqCase.Occupied)
					{
						Phase = 8;
					}
					else
					{
						Phase++;
					}
				}
				else if (Police.BloodyClothing > 0)
				{
					Label.text = "The police find bloody clothing that has traces of Yandere-chan's DNA. Yandere-chan is unable to convince the police that she did not commit murder.";
					Phase = 100;
				}
				else
				{
					Label.text = "The police question all students in the school, including Yandere-chan. The police are unable to link Yandere-chan to any crimes.";
					if (!TranqCase.Occupied)
					{
						Phase = 8;
					}
					else if (TranqCase.VictimID == ArrestID)
					{
						Phase = 8;
					}
					else
					{
						Phase++;
					}
				}
			}
			else if (Yandere.Bloodiness == 0f)
			{
				Label.text = "The police question Yandere-chan, who exhibits extremely unusual behavior. The police decide to investigate Yandere-chan further, and eventually learn of her crimes.";
				Phase = 100;
			}
			else
			{
				Label.text = "The police notice that Yandere-chan is covered in blood and exhibiting extremely unusual behavior. The police decide to investigate Yandere-chan further, and eventually learn of her crimes.";
				Phase = 100;
			}
		}
		else if (Phase == 7)
		{
			Label.text = "The police discover " + JSON.Students[TranqCase.VictimID].Name + " inside of a musical instrument case. However, she is unable to recall how she got inside of the case. The police are unable to determine what happened.";
			StudentGlobals.SetStudentKidnapped(TranqCase.VictimID, false);
			StudentGlobals.SetStudentMissing(TranqCase.VictimID, false);
			TranqCase.VictimClubType = ClubType.None;
			TranqCase.VictimID = 0;
			TranqCase.Occupied = false;
			Phase++;
		}
		else if (Phase == 8)
		{
			if (Police.MaskReported)
			{
				GameGlobals.MasksBanned = true;
				if (SecuritySystem.Masked)
				{
					Label.text = "In security camera footage, the killer was wearing a mask. As a result, the police are unable to gather meaningful information about the murderer. To prevent this from ever happening again, the Headmaster decides to ban all masks from the school from this day forward.";
				}
				else
				{
					Label.text = "Witnesses state that the killer was wearing a mask. As a result, the police are unable to gather meaningful information about the murderer. To prevent this from ever happening again, the Headmaster decides to ban all masks from the school from this day forward.";
				}
				Police.MaskReported = false;
				Phase++;
			}
			else
			{
				Phase++;
				UpdateScene();
			}
		}
		else if (Phase == 9)
		{
			if (Arrests == 0)
			{
				if (DeadPerps == 0)
				{
					Label.text = "The police do not have enough evidence to perform an arrest. The police investigation ends, and students are free to leave.";
					Phase++;
				}
				else
				{
					Label.text = "The police conclude that a murder-suicide took place, but are unable to take any further action. The police investigation ends, and students are free to leave.";
					Phase++;
				}
			}
			else
			{
				Label.text = "The police believe that they have arrested the perpetrator of the crime. The police investigation ends, and students are free to leave.";
				Phase++;
			}
		}
		else if (Phase == 10)
		{
			Label.text = "Yandere-chan stalks Senpai until he has returned home safely, and then returns to her own home.";
			Phase++;
		}
		else if (Phase == 11)
		{
			if (!StudentGlobals.GetStudentDying(7) && !StudentGlobals.GetStudentDead(7) && !StudentGlobals.GetStudentArrested(7))
			{
				if (Counselor.LectureID > 0)
				{
					Counselor.Lecturing = true;
					base.enabled = false;
				}
				else
				{
					Phase++;
					UpdateScene();
				}
			}
			else
			{
				Phase++;
				UpdateScene();
			}
		}
		else if (Phase == 12)
		{
			Debug.Log("Phase 12.");
			if (SchemeGlobals.GetSchemeStage(2) == 3)
			{
				if (!StudentGlobals.GetStudentDying(7) && !StudentGlobals.GetStudentDead(7) && !StudentGlobals.GetStudentArrested(7))
				{
					Label.text = "Kokona discovers Sakyu's ring inside of her book bag. She returns the ring to Sakyu, who decides to never let it out of her sight again.";
					SchemeGlobals.SetSchemeStage(2, 100);
				}
			}
			else if (SchemeGlobals.GetSchemeStage(5) > 1 && SchemeGlobals.GetSchemeStage(5) < 5)
			{
				Label.text = "A faculty member discovers that an answer sheet for an upcoming test is missing. She changes all of the questions for the test and keeps the new answer sheet with her at all times.";
				SchemeGlobals.SetSchemeStage(5, 100);
			}
			else
			{
				Phase++;
				UpdateScene();
			}
		}
		else if (Phase == 13)
		{
			Debug.Log("Phase 13 - checking for clubs shutting down.");
			ClubClosed = false;
			ClubKicked = false;
			if (ClubID < ClubArray.Length)
			{
				if (!ClubGlobals.GetClubClosed(ClubArray[ClubID]))
				{
					Debug.Log("Right now, we're checking the " + ClubNames[ClubID].ToString() + ".");
					ClubManager.CheckClub(ClubArray[ClubID]);
					if (ClubManager.ClubMembers < 5)
					{
						ClubGlobals.SetClubClosed(ClubArray[ClubID], true);
						Label.text = "The " + ClubNames[ClubID].ToString() + " no longer has enough members to remain operational. The school forces the club to disband.";
						ClubClosed = true;
						if (ClubGlobals.Club == ClubArray[ClubID])
						{
							ClubGlobals.Club = ClubType.None;
						}
					}
					if (ClubManager.LeaderMissing)
					{
						ClubGlobals.SetClubClosed(ClubArray[ClubID], true);
						Label.text = "The leader of the " + ClubNames[ClubID].ToString() + " has gone missing. The " + ClubNames[ClubID].ToString() + " cannot operate without its leader. The club disbands.";
						ClubClosed = true;
						if (ClubGlobals.Club == ClubArray[ClubID])
						{
							ClubGlobals.Club = ClubType.None;
						}
					}
					else if (ClubManager.LeaderDead)
					{
						ClubGlobals.SetClubClosed(ClubArray[ClubID], true);
						Label.text = "The leader of the " + ClubNames[ClubID].ToString() + " is gone. The " + ClubNames[ClubID].ToString() + " cannot operate without its leader. The club disbands.";
						ClubClosed = true;
						if (ClubGlobals.Club == ClubArray[ClubID])
						{
							ClubGlobals.Club = ClubType.None;
						}
					}
				}
				if (!ClubGlobals.GetClubClosed(ClubArray[ClubID]) && !ClubGlobals.GetClubKicked(ClubArray[ClubID]) && ClubGlobals.Club == ClubArray[ClubID])
				{
					ClubManager.CheckGrudge(ClubArray[ClubID]);
					if (ClubManager.LeaderGrudge)
					{
						Label.text = "Yandere-chan receives a text message from the president of the " + ClubNames[ClubID].ToString() + ". Yandere-chan is no longer a member of the " + ClubNames[ClubID].ToString() + ", and is not welcome in the " + ClubNames[ClubID].ToString() + " room.";
						ClubGlobals.SetClubKicked(ClubArray[ClubID], true);
						ClubGlobals.Club = ClubType.None;
						ClubKicked = true;
					}
					else if (ClubManager.ClubGrudge)
					{
						Label.text = "Yandere-chan receives a text message from the president of the " + ClubNames[ClubID].ToString() + ". There is someone in the " + ClubNames[ClubID].ToString() + " who hates and fears Yandere-chan. Yandere-chan is no longer a member of the " + ClubNames[ClubID].ToString() + ", and is not welcome in the " + ClubNames[ClubID].ToString() + " room.";
						ClubGlobals.SetClubKicked(ClubArray[ClubID], true);
						ClubGlobals.Club = ClubType.None;
						ClubKicked = true;
					}
				}
				if (!ClubClosed && !ClubKicked)
				{
					ClubID++;
					UpdateScene();
				}
			}
			else
			{
				Phase++;
				UpdateScene();
			}
		}
		else if (Phase == 14)
		{
			Debug.Log("Phase 14.");
			if (TranqCase.Occupied)
			{
				Label.color = new Color(Label.color.r, Label.color.g, Label.color.b, 1f);
				Label.text = "Yandere-chan waits until the clock strikes midnight.\n\nUnder the cover of darkness, Yandere-chan travels back to school and sneaks inside of the main school building.\n\nYandere-chan returns to the instrument case that carries her unconscious victim.\n\nShe pushes the case back to her house, pretending to be a young musician returning home from a late-night show.\n\nYandere-chan drags the case down to her basement and ties up her victim.\n\nExhausted, Yandere-chan goes to sleep.";
				Phase++;
			}
			else
			{
				Phase++;
				UpdateScene();
			}
		}
		else if (Phase == 15)
		{
			Debug.Log("Phase 15.");
			if (ErectFence)
			{
				Label.text = "To prevent any other students from falling off of the school rooftop, the school erects a fence around the roof.";
				SchoolGlobals.RoofFence = true;
				ErectFence = false;
			}
			else
			{
				Phase++;
				UpdateScene();
			}
		}
		else if (Phase == 16)
		{
			Debug.Log("Phase 16.");
			if (!SchoolGlobals.HighSecurity && Police.CouncilDeath)
			{
				Label.text = "The student council president has ordered the implementation of heightened security precautions. Security cameras and metal detectors are now present at school.";
				Police.CouncilDeath = false;
			}
			else
			{
				Phase++;
				UpdateScene();
			}
		}
		else if (Phase == 17)
		{
			Finish();
		}
		else if (Phase == 100)
		{
			Label.text = "Yandere-chan is arrested by the police. She will never have Senpai.";
			GameOver = true;
		}
		else if (Phase == 101)
		{
			int fingerprintID = WeaponManager.Weapons[WeaponID].FingerprintID;
			StudentScript studentScript = StudentManager.Students[fingerprintID];
			if (studentScript.Alive)
			{
				if (!studentScript.Tranquil)
				{
					Label.text = JSON.Students[fingerprintID].Name + " is arrested by the police.";
					StudentGlobals.SetStudentArrested(fingerprintID, true);
					Arrests++;
				}
				else
				{
					Label.text = JSON.Students[fingerprintID].Name + " is found asleep inside of a musical instrument case. The police assume that she hid herself inside of the box after committing murder, and arrest her.";
					StudentGlobals.SetStudentArrested(fingerprintID, true);
					ArrestID = fingerprintID;
					TranqCase.Occupied = false;
					Arrests++;
				}
			}
			else
			{
				bool flag = false;
				for (ID = 0; ID < VictimArray.Length; ID++)
				{
					if (VictimArray[ID] == fingerprintID && !studentScript.MurderSuicide)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					Label.text = JSON.Students[fingerprintID].Name + " is dead. The police cannot perform an arrest.";
					DeadPerps++;
				}
				else
				{
					Label.text = JSON.Students[fingerprintID].Name + "'s fingerprints are on the same weapon that killed them. The police cannot solve this mystery.";
				}
			}
			Phase = 6;
		}
		else if (Phase == 102)
		{
			if (Police.SuicideStudent.activeInHierarchy)
			{
				Label.text = "The police inspect the corpse of a student who appears to have fallen to their death from the school rooftop. The police treat the incident as a murder case, and search the school for any other victims.";
				ErectFence = true;
			}
			else
			{
				Label.text = "The police attempt to determine whether or not a student fell to their death from the school rooftop. The police are unable to reach a conclusion.";
			}
			for (ID = 0; ID < Police.CorpseList.Length; ID++)
			{
				RagdollScript ragdollScript2 = Police.CorpseList[ID];
				if (ragdollScript2 != null && ragdollScript2.Suicide)
				{
					ragdollScript2 = null;
					Police.Corpses--;
				}
			}
			Phase = 2;
		}
		else if (Phase == 103)
		{
			Label.text = "The paramedics attempt to resuscitate the poisoned student, but they are unable to revive her. The police treat the incident as a murder case, and search the school for any other victims.";
			for (ID = 0; ID < Police.CorpseList.Length; ID++)
			{
				RagdollScript ragdollScript3 = Police.CorpseList[ID];
				if (ragdollScript3 != null && ragdollScript3.Poisoned)
				{
					ragdollScript3 = null;
					Police.Corpses--;
				}
			}
			Phase = 2;
		}
		else if (Phase == 104)
		{
			Label.text = "The police determine that " + Police.DrownedStudentName + " died from drowning. The police treat her death as a possible murder, and search the school for any other victims.";
			for (ID = 0; ID < Police.CorpseList.Length; ID++)
			{
				RagdollScript ragdollScript4 = Police.CorpseList[ID];
				if (ragdollScript4 != null && ragdollScript4.Drowned)
				{
					ragdollScript4 = null;
					Police.Corpses--;
				}
			}
			Phase = 2;
		}
		else
		{
			if (Phase != 105)
			{
				return;
			}
			Label.text = "The police determine that " + Police.ElectrocutedStudentName + " died from being electrocuted. The police treat her death as a possible murder, and search the school for any other victims.";
			for (ID = 0; ID < Police.CorpseList.Length; ID++)
			{
				RagdollScript ragdollScript5 = Police.CorpseList[ID];
				if (ragdollScript5 != null && ragdollScript5.Electrocuted)
				{
					ragdollScript5 = null;
					Police.Corpses--;
				}
			}
			Phase = 2;
		}
	}

	private void Finish()
	{
		PlayerGlobals.Reputation = Reputation.Reputation;
		HomeGlobals.Night = true;
		Police.KillStudents();
		if (StudentManager.Students[SchoolGlobals.KidnapVictim] != null && StudentManager.Students[SchoolGlobals.KidnapVictim].Ragdoll.enabled)
		{
			SchoolGlobals.KidnapVictim = 0;
		}
		if (!TranqCase.Occupied)
		{
			SceneManager.LoadScene("HomeScene");
		}
		else
		{
			SchoolGlobals.KidnapVictim = TranqCase.VictimID;
			StudentGlobals.SetStudentKidnapped(TranqCase.VictimID, true);
			StudentGlobals.SetStudentSanity(TranqCase.VictimID, 100f);
			SceneManager.LoadScene("CalendarScene");
		}
		if (Dumpster.StudentToGoMissing > 0)
		{
			Dumpster.SetVictimMissing();
		}
		for (ID = 0; ID < GardenHoles.Length; ID++)
		{
			GardenHoles[ID].EndOfDayCheck();
		}
		Incinerator.SetVictimsMissing();
		WoodChipper.SetVictimsMissing();
		if (FragileTarget > 0)
		{
			Debug.Log("Setting target for Fragile student.");
			StudentGlobals.SetFragileTarget(FragileTarget);
			StudentGlobals.SetStudentFragileSlave(32);
		}
	}
}
