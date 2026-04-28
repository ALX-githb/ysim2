using UnityEngine;

public class SubtitleScript : MonoBehaviour
{
	public JukeboxScript Jukebox;

	public Transform Yandere;

	public UILabel Label;

	public string[] WeaponBloodInsanityReactions;

	public string[] WeaponBloodReactions;

	public string[] WeaponInsanityReactions;

	public string[] BloodInsanityReactions;

	public string[] BloodReactions;

	public string[] WetBloodReactions;

	public string[] InsanityReactions;

	public string[] LewdReactions;

	public string[] SuspiciousReactions;

	public string[] MurderReactions;

	public string[] CowardMurderReactions;

	public string[] EvilMurderReactions;

	public string[] PetMurderReports;

	public string[] PetMurderReactions;

	public string[] PetCorpseReports;

	public string[] PetCorpseReactions;

	public string[] HeroMurderReactions;

	public string[] LonerMurderReactions;

	public string[] LonerCorpseReactions;

	public string[] EvilCorpseReactions;

	public string[] EvilDelinquentCorpseReactions;

	public string[] SocialDeathReactions;

	public string[] LovestruckDeathReactions;

	public string[] LovestruckMurderReports;

	public string[] LovestruckCorpseReports;

	public string[] SocialReports;

	public string[] SocialFears;

	public string[] SocialTerrors;

	public string[] RepeatReactions;

	public string[] CorpseReactions;

	public string[] PrankReactions;

	public string[] InterruptReactions;

	public string[] IntrusionReactions;

	public string[] NoteReactions;

	public string[] FoodAccepts;

	public string[] FoodRejects;

	public string[] EavesdropReactions;

	public string[] ViolenceReactions;

	public string[] EventEavesdropReactions;

	public string[] RivalEavesdropReactions;

	public string[] PickpocketReactions;

	public string[] RivalPickpocketReactions;

	public string[] DrownReactions;

	public string[] KilledMoods;

	public string[] KnifeReactions;

	public string[] SyringeReactions;

	public string[] KatanaReactions;

	public string[] SawReactions;

	public string[] RitualReactions;

	public string[] BatReactions;

	public string[] ShovelReactions;

	public string[] DumbbellReactions;

	public string[] AxeReactions;

	public string[] PropReactions;

	public string[] DelinkWeaponReactions;

	public string[] WeaponBloodApologies;

	public string[] WeaponApologies;

	public string[] BloodApologies;

	public string[] InsanityApologies;

	public string[] LewdApologies;

	public string[] SuspiciousApologies;

	public string[] EventApologies;

	public string[] ClassApologies;

	public string[] AccidentApologies;

	public string[] SadApologies;

	public string[] EavesdropApologies;

	public string[] ViolenceApologies;

	public string[] PickpocketApologies;

	public string[] Greetings;

	public string[] PlayerFarewells;

	public string[] StudentFarewells;

	public string[] Forgivings;

	public string[] AccidentForgivings;

	public string[] InsanityForgivings;

	public string[] PlayerCompliments;

	public string[] StudentHighCompliments;

	public string[] StudentMidCompliments;

	public string[] StudentLowCompliments;

	public string[] PlayerGossip;

	public string[] StudentGossip;

	public string[] PlayerFollows;

	public string[] StudentFollows;

	public string[] PlayerLeaves;

	public string[] StudentLeaves;

	public string[] StudentStays;

	public string[] PlayerDistracts;

	public string[] StudentDistracts;

	public string[] StudentDistractRefuses;

	public string[] StudentDistractBullyRefuses;

	public string[] StopFollowApologies;

	public string[] GrudgeWarnings;

	public string[] GrudgeRefusals;

	public string[] CowardGrudges;

	public string[] EvilGrudges;

	public string[] PlayerLove;

	public string[] SuitorLove;

	public string[] RivalLove;

	public string[] Impatiences;

	public string[] ImpatientFarewells;

	public string[] Deaths;

	public string[] SenpaiInsanityReactions;

	public string[] SenpaiWeaponReactions;

	public string[] SenpaiBloodReactions;

	public string[] SenpaiLewdReactions;

	public string[] SenpaiStalkingReactions;

	public string[] SenpaiMurderReactions;

	public string[] SenpaiCorpseReactions;

	public string[] SenpaiViolenceReactions;

	public string[] TeacherInsanityReactions;

	public string[] TeacherWeaponReactions;

	public string[] TeacherBloodReactions;

	public string[] TeacherInsanityHostiles;

	public string[] TeacherWeaponHostiles;

	public string[] TeacherBloodHostiles;

	public string[] TeacherLewdReactions;

	public string[] TeacherTrespassReactions;

	public string[] TeacherLateReactions;

	public string[] TeacherReportReactions;

	public string[] TeacherCorpseReactions;

	public string[] TeacherCorpseInspections;

	public string[] TeacherPoliceReports;

	public string[] TeacherAttackReactions;

	public string[] TeacherMurderReactions;

	public string[] TeacherPrankReactions;

	public string[] TeacherTheftReactions;

	public string[] DelinquentAnnoys;

	public string[] DelinquentCases;

	public string[] DelinquentShoves;

	public string[] DelinquentReactions;

	public string[] DelinquentWeaponReactions;

	public string[] DelinquentThreateneds;

	public string[] DelinquentTaunts;

	public string[] DelinquentCalms;

	public string[] DelinquentFights;

	public string[] DelinquentAvenges;

	public string[] DelinquentWins;

	public string[] DelinquentSurrenders;

	public string[] DelinquentNoSurrenders;

	public string[] DelinquentMurderReactions;

	public string[] DelinquentCorpseReactions;

	public string[] DelinquentFriendCorpseReactions;

	public string[] DelinquentResumes;

	public string[] DelinquentFlees;

	public string[] DelinquentEnemyFlees;

	public string[] DelinquentFriendFlees;

	public string[] DelinquentInjuredFlees;

	public string[] DelinquentCheers;

	public string[] DelinquentHmms;

	public string[] DelinquentGrudges;

	public string[] Dismissives;

	public string[] LostPhones;

	public string[] RivalLostPhones;

	public string[] StudentMurderReports;

	public string[] YandereWhimpers;

	public string[] SplashReactions;

	public string[] RivalSplashReactions;

	public string[] LightSwitchReactions;

	public string[] PhotoAnnoyances;

	public string[] Task6Lines;

	public string[] Task7Lines;

	public string[] Task13Lines;

	public string[] Task14Lines;

	public string[] Task15Lines;

	public string[] Task32Lines;

	public string[] Task33Lines;

	public string[] Task34Lines;

	public string[] Task81Lines;

	public string[] Club0Info;

	public string[] Club3Info;

	public string[] Club4Info;

	public string[] Club6Info;

	public string[] Club7InfoLight;

	public string[] Club7InfoDark;

	public string[] Club8Info;

	public string[] Club9Info;

	public string[] Club10Info;

	public string[] ClubGreetings;

	public string[] ClubUnwelcomes;

	public string[] ClubKicks;

	public string[] ClubJoins;

	public string[] ClubAccepts;

	public string[] ClubRefuses;

	public string[] ClubRejoins;

	public string[] ClubExclusives;

	public string[] ClubGrudges;

	public string[] ClubQuits;

	public string[] ClubConfirms;

	public string[] ClubDenies;

	public string[] ClubFarewells;

	public string[] ClubActivities;

	public string[] ClubEarlies;

	public string[] ClubLates;

	public string[] ClubYeses;

	public string[] ClubNoes;

	public string[] StrictReaction;

	public string[] CasualReaction;

	public string[] GraceReaction;

	public string[] EdgyReaction;

	public string[] Spraying;

	public string[] Shoving;

	public string[] Chasing;

	public string[] CouncilCorpseReactions;

	public string[] HmmReactions;

	public string InfoNotice;

	public int RandomID;

	public float Timer;

	public AudioClip[] NoteReactionClips;

	public AudioClip[] GrudgeWarningClips;

	public AudioClip[] SenpaiInsanityReactionClips;

	public AudioClip[] SenpaiWeaponReactionClips;

	public AudioClip[] SenpaiBloodReactionClips;

	public AudioClip[] SenpaiLewdReactionClips;

	public AudioClip[] SenpaiStalkingReactionClips;

	public AudioClip[] SenpaiMurderReactionClips;

	public AudioClip[] SenpaiViolenceReactionClips;

	public AudioClip[] YandereWhimperClips;

	public AudioClip[] TeacherWeaponClips;

	public AudioClip[] TeacherBloodClips;

	public AudioClip[] TeacherInsanityClips;

	public AudioClip[] TeacherWeaponHostileClips;

	public AudioClip[] TeacherBloodHostileClips;

	public AudioClip[] TeacherInsanityHostileClips;

	public AudioClip[] TeacherLewdClips;

	public AudioClip[] TeacherTrespassClips;

	public AudioClip[] TeacherLateClips;

	public AudioClip[] TeacherReportClips;

	public AudioClip[] TeacherCorpseClips;

	public AudioClip[] TeacherInspectClips;

	public AudioClip[] TeacherPoliceClips;

	public AudioClip[] TeacherAttackClips;

	public AudioClip[] TeacherMurderClips;

	public AudioClip[] TeacherPrankClips;

	public AudioClip[] TeacherTheftClips;

	public AudioClip[] LostPhoneClips;

	public AudioClip[] RivalLostPhoneClips;

	public AudioClip[] PickpocketReactionClips;

	public AudioClip[] RivalPickpocketReactionClips;

	public AudioClip[] SplashReactionClips;

	public AudioClip[] RivalSplashReactionClips;

	public AudioClip[] DrownReactionClips;

	public AudioClip[] LightSwitchClips;

	public AudioClip[] Task6Clips;

	public AudioClip[] Task7Clips;

	public AudioClip[] Task13Clips;

	public AudioClip[] Task14Clips;

	public AudioClip[] Task15Clips;

	public AudioClip[] Task32Clips;

	public AudioClip[] Task33Clips;

	public AudioClip[] Task34Clips;

	public AudioClip[] Task81Clips;

	public AudioClip[] Club0Clips;

	public AudioClip[] Club3Clips;

	public AudioClip[] Club4Clips;

	public AudioClip[] Club6Clips;

	public AudioClip[] Club7ClipsLight;

	public AudioClip[] Club7ClipsDark;

	public AudioClip[] Club8Clips;

	public AudioClip[] Club9Clips;

	public AudioClip[] Club10Clips;

	public AudioClip[] ClubGreetingClips;

	public AudioClip[] ClubUnwelcomeClips;

	public AudioClip[] ClubKickClips;

	public AudioClip[] ClubJoinClips;

	public AudioClip[] ClubAcceptClips;

	public AudioClip[] ClubRefuseClips;

	public AudioClip[] ClubRejoinClips;

	public AudioClip[] ClubExclusiveClips;

	public AudioClip[] ClubGrudgeClips;

	public AudioClip[] ClubQuitClips;

	public AudioClip[] ClubConfirmClips;

	public AudioClip[] ClubDenyClips;

	public AudioClip[] ClubFarewellClips;

	public AudioClip[] ClubActivityClips;

	public AudioClip[] ClubEarlyClips;

	public AudioClip[] ClubLateClips;

	public AudioClip[] ClubYesClips;

	public AudioClip[] ClubNoClips;

	public AudioClip[] EavesdropClips;

	public AudioClip[] FoodRejectionClips;

	public AudioClip[] ViolenceClips;

	public AudioClip[] EventEavesdropClips;

	public AudioClip[] RivalEavesdropClips;

	public AudioClip[] DelinquentAnnoyClips;

	public AudioClip[] DelinquentCaseClips;

	public AudioClip[] DelinquentShoveClips;

	public AudioClip[] DelinquentReactionClips;

	public AudioClip[] DelinquentWeaponReactionClips;

	public AudioClip[] DelinquentThreatenedClips;

	public AudioClip[] DelinquentTauntClips;

	public AudioClip[] DelinquentCalmClips;

	public AudioClip[] DelinquentFightClips;

	public AudioClip[] DelinquentAvengeClips;

	public AudioClip[] DelinquentWinClips;

	public AudioClip[] DelinquentSurrenderClips;

	public AudioClip[] DelinquentNoSurrenderClips;

	public AudioClip[] DelinquentMurderReactionClips;

	public AudioClip[] DelinquentCorpseReactionClips;

	public AudioClip[] DelinquentFriendCorpseReactionClips;

	public AudioClip[] DelinquentResumeClips;

	public AudioClip[] DelinquentFleeClips;

	public AudioClip[] DelinquentEnemyFleeClips;

	public AudioClip[] DelinquentFriendFleeClips;

	public AudioClip[] DelinquentInjuredFleeClips;

	public AudioClip[] DelinquentCheerClips;

	public AudioClip[] DelinquentHmmClips;

	public AudioClip[] DelinquentGrudgeClips;

	public AudioClip[] DismissiveClips;

	public AudioClip[] EvilDelinquentCorpseReactionClips;

	private SubtitleTypeAndAudioClipArrayDictionary SubtitleClipArrays;

	public GameObject CurrentClip;

	private void Awake()
	{
		SubtitleClipArrays = new SubtitleTypeAndAudioClipArrayDictionary
		{
			{
				SubtitleType.ClubAccept,
				new AudioClipArrayWrapper(ClubAcceptClips)
			},
			{
				SubtitleType.ClubActivity,
				new AudioClipArrayWrapper(ClubActivityClips)
			},
			{
				SubtitleType.ClubArtInfo,
				new AudioClipArrayWrapper(Club4Clips)
			},
			{
				SubtitleType.ClubConfirm,
				new AudioClipArrayWrapper(ClubConfirmClips)
			},
			{
				SubtitleType.ClubDeny,
				new AudioClipArrayWrapper(ClubDenyClips)
			},
			{
				SubtitleType.ClubEarly,
				new AudioClipArrayWrapper(ClubEarlyClips)
			},
			{
				SubtitleType.ClubExclusive,
				new AudioClipArrayWrapper(ClubExclusiveClips)
			},
			{
				SubtitleType.ClubFarewell,
				new AudioClipArrayWrapper(ClubFarewellClips)
			},
			{
				SubtitleType.ClubGreeting,
				new AudioClipArrayWrapper(ClubGreetingClips)
			},
			{
				SubtitleType.ClubGrudge,
				new AudioClipArrayWrapper(ClubGrudgeClips)
			},
			{
				SubtitleType.ClubJoin,
				new AudioClipArrayWrapper(ClubJoinClips)
			},
			{
				SubtitleType.ClubKick,
				new AudioClipArrayWrapper(ClubKickClips)
			},
			{
				SubtitleType.ClubLate,
				new AudioClipArrayWrapper(ClubLateClips)
			},
			{
				SubtitleType.ClubMartialArtsInfo,
				new AudioClipArrayWrapper(Club6Clips)
			},
			{
				SubtitleType.ClubNo,
				new AudioClipArrayWrapper(ClubNoClips)
			},
			{
				SubtitleType.ClubOccultInfo,
				new AudioClipArrayWrapper(Club3Clips)
			},
			{
				SubtitleType.ClubPlaceholderInfo,
				new AudioClipArrayWrapper(Club0Clips)
			},
			{
				SubtitleType.ClubPhotoInfoLight,
				new AudioClipArrayWrapper(Club7ClipsLight)
			},
			{
				SubtitleType.ClubPhotoInfoDark,
				new AudioClipArrayWrapper(Club7ClipsDark)
			},
			{
				SubtitleType.ClubScienceInfo,
				new AudioClipArrayWrapper(Club8Clips)
			},
			{
				SubtitleType.ClubSportsInfo,
				new AudioClipArrayWrapper(Club9Clips)
			},
			{
				SubtitleType.ClubGardenInfo,
				new AudioClipArrayWrapper(Club10Clips)
			},
			{
				SubtitleType.ClubQuit,
				new AudioClipArrayWrapper(ClubQuitClips)
			},
			{
				SubtitleType.ClubRefuse,
				new AudioClipArrayWrapper(ClubRefuseClips)
			},
			{
				SubtitleType.ClubRejoin,
				new AudioClipArrayWrapper(ClubRejoinClips)
			},
			{
				SubtitleType.ClubUnwelcome,
				new AudioClipArrayWrapper(ClubUnwelcomeClips)
			},
			{
				SubtitleType.ClubYes,
				new AudioClipArrayWrapper(ClubYesClips)
			},
			{
				SubtitleType.DrownReaction,
				new AudioClipArrayWrapper(DrownReactionClips)
			},
			{
				SubtitleType.EavesdropReaction,
				new AudioClipArrayWrapper(EavesdropClips)
			},
			{
				SubtitleType.RejectFood,
				new AudioClipArrayWrapper(FoodRejectionClips)
			},
			{
				SubtitleType.ViolenceReaction,
				new AudioClipArrayWrapper(ViolenceClips)
			},
			{
				SubtitleType.EventEavesdropReaction,
				new AudioClipArrayWrapper(EventEavesdropClips)
			},
			{
				SubtitleType.RivalEavesdropReaction,
				new AudioClipArrayWrapper(RivalEavesdropClips)
			},
			{
				SubtitleType.GrudgeWarning,
				new AudioClipArrayWrapper(GrudgeWarningClips)
			},
			{
				SubtitleType.LightSwitchReaction,
				new AudioClipArrayWrapper(LightSwitchClips)
			},
			{
				SubtitleType.LostPhone,
				new AudioClipArrayWrapper(LostPhoneClips)
			},
			{
				SubtitleType.NoteReaction,
				new AudioClipArrayWrapper(NoteReactionClips)
			},
			{
				SubtitleType.PickpocketReaction,
				new AudioClipArrayWrapper(PickpocketReactionClips)
			},
			{
				SubtitleType.RivalLostPhone,
				new AudioClipArrayWrapper(RivalLostPhoneClips)
			},
			{
				SubtitleType.RivalPickpocketReaction,
				new AudioClipArrayWrapper(RivalPickpocketReactionClips)
			},
			{
				SubtitleType.RivalSplashReaction,
				new AudioClipArrayWrapper(RivalSplashReactionClips)
			},
			{
				SubtitleType.SenpaiBloodReaction,
				new AudioClipArrayWrapper(SenpaiBloodReactionClips)
			},
			{
				SubtitleType.SenpaiInsanityReaction,
				new AudioClipArrayWrapper(SenpaiInsanityReactionClips)
			},
			{
				SubtitleType.SenpaiLewdReaction,
				new AudioClipArrayWrapper(SenpaiLewdReactionClips)
			},
			{
				SubtitleType.SenpaiMurderReaction,
				new AudioClipArrayWrapper(SenpaiMurderReactionClips)
			},
			{
				SubtitleType.SenpaiStalkingReaction,
				new AudioClipArrayWrapper(SenpaiStalkingReactionClips)
			},
			{
				SubtitleType.SenpaiWeaponReaction,
				new AudioClipArrayWrapper(SenpaiWeaponReactionClips)
			},
			{
				SubtitleType.SenpaiViolenceReaction,
				new AudioClipArrayWrapper(SenpaiViolenceReactionClips)
			},
			{
				SubtitleType.SplashReaction,
				new AudioClipArrayWrapper(SplashReactionClips)
			},
			{
				SubtitleType.Task6Line,
				new AudioClipArrayWrapper(Task6Clips)
			},
			{
				SubtitleType.Task7Line,
				new AudioClipArrayWrapper(Task7Clips)
			},
			{
				SubtitleType.Task13Line,
				new AudioClipArrayWrapper(Task13Clips)
			},
			{
				SubtitleType.Task14Line,
				new AudioClipArrayWrapper(Task14Clips)
			},
			{
				SubtitleType.Task15Line,
				new AudioClipArrayWrapper(Task15Clips)
			},
			{
				SubtitleType.Task32Line,
				new AudioClipArrayWrapper(Task32Clips)
			},
			{
				SubtitleType.Task33Line,
				new AudioClipArrayWrapper(Task33Clips)
			},
			{
				SubtitleType.Task34Line,
				new AudioClipArrayWrapper(Task34Clips)
			},
			{
				SubtitleType.Task81Line,
				new AudioClipArrayWrapper(Task81Clips)
			},
			{
				SubtitleType.TeacherAttackReaction,
				new AudioClipArrayWrapper(TeacherAttackClips)
			},
			{
				SubtitleType.TeacherBloodHostile,
				new AudioClipArrayWrapper(TeacherBloodHostileClips)
			},
			{
				SubtitleType.TeacherBloodReaction,
				new AudioClipArrayWrapper(TeacherBloodClips)
			},
			{
				SubtitleType.TeacherCorpseInspection,
				new AudioClipArrayWrapper(TeacherInspectClips)
			},
			{
				SubtitleType.TeacherCorpseReaction,
				new AudioClipArrayWrapper(TeacherCorpseClips)
			},
			{
				SubtitleType.TeacherInsanityHostile,
				new AudioClipArrayWrapper(TeacherInsanityHostileClips)
			},
			{
				SubtitleType.TeacherInsanityReaction,
				new AudioClipArrayWrapper(TeacherInsanityClips)
			},
			{
				SubtitleType.TeacherLateReaction,
				new AudioClipArrayWrapper(TeacherLateClips)
			},
			{
				SubtitleType.TeacherLewdReaction,
				new AudioClipArrayWrapper(TeacherLewdClips)
			},
			{
				SubtitleType.TeacherMurderReaction,
				new AudioClipArrayWrapper(TeacherMurderClips)
			},
			{
				SubtitleType.TeacherPoliceReport,
				new AudioClipArrayWrapper(TeacherPoliceClips)
			},
			{
				SubtitleType.TeacherPrankReaction,
				new AudioClipArrayWrapper(TeacherPrankClips)
			},
			{
				SubtitleType.TeacherReportReaction,
				new AudioClipArrayWrapper(TeacherReportClips)
			},
			{
				SubtitleType.TeacherTheftReaction,
				new AudioClipArrayWrapper(TeacherTheftClips)
			},
			{
				SubtitleType.TeacherTrespassingReaction,
				new AudioClipArrayWrapper(TeacherTrespassClips)
			},
			{
				SubtitleType.TeacherWeaponHostile,
				new AudioClipArrayWrapper(TeacherWeaponHostileClips)
			},
			{
				SubtitleType.TeacherWeaponReaction,
				new AudioClipArrayWrapper(TeacherWeaponClips)
			},
			{
				SubtitleType.YandereWhimper,
				new AudioClipArrayWrapper(YandereWhimperClips)
			},
			{
				SubtitleType.DelinquentAnnoy,
				new AudioClipArrayWrapper(DelinquentAnnoyClips)
			},
			{
				SubtitleType.DelinquentCase,
				new AudioClipArrayWrapper(DelinquentCaseClips)
			},
			{
				SubtitleType.DelinquentShove,
				new AudioClipArrayWrapper(DelinquentShoveClips)
			},
			{
				SubtitleType.DelinquentReaction,
				new AudioClipArrayWrapper(DelinquentReactionClips)
			},
			{
				SubtitleType.DelinquentWeaponReaction,
				new AudioClipArrayWrapper(DelinquentWeaponReactionClips)
			},
			{
				SubtitleType.DelinquentThreatened,
				new AudioClipArrayWrapper(DelinquentThreatenedClips)
			},
			{
				SubtitleType.DelinquentTaunt,
				new AudioClipArrayWrapper(DelinquentTauntClips)
			},
			{
				SubtitleType.DelinquentCalm,
				new AudioClipArrayWrapper(DelinquentCalmClips)
			},
			{
				SubtitleType.DelinquentFight,
				new AudioClipArrayWrapper(DelinquentFightClips)
			},
			{
				SubtitleType.DelinquentAvenge,
				new AudioClipArrayWrapper(DelinquentAvengeClips)
			},
			{
				SubtitleType.DelinquentWin,
				new AudioClipArrayWrapper(DelinquentWinClips)
			},
			{
				SubtitleType.DelinquentSurrender,
				new AudioClipArrayWrapper(DelinquentSurrenderClips)
			},
			{
				SubtitleType.DelinquentNoSurrender,
				new AudioClipArrayWrapper(DelinquentNoSurrenderClips)
			},
			{
				SubtitleType.DelinquentMurderReaction,
				new AudioClipArrayWrapper(DelinquentMurderReactionClips)
			},
			{
				SubtitleType.DelinquentCorpseReaction,
				new AudioClipArrayWrapper(DelinquentCorpseReactionClips)
			},
			{
				SubtitleType.DelinquentFriendCorpseReaction,
				new AudioClipArrayWrapper(DelinquentFriendCorpseReactionClips)
			},
			{
				SubtitleType.DelinquentResume,
				new AudioClipArrayWrapper(DelinquentResumeClips)
			},
			{
				SubtitleType.DelinquentFlee,
				new AudioClipArrayWrapper(DelinquentFleeClips)
			},
			{
				SubtitleType.DelinquentEnemyFlee,
				new AudioClipArrayWrapper(DelinquentEnemyFleeClips)
			},
			{
				SubtitleType.DelinquentFriendFlee,
				new AudioClipArrayWrapper(DelinquentFriendFleeClips)
			},
			{
				SubtitleType.DelinquentInjuredFlee,
				new AudioClipArrayWrapper(DelinquentInjuredFleeClips)
			},
			{
				SubtitleType.DelinquentCheer,
				new AudioClipArrayWrapper(DelinquentCheerClips)
			},
			{
				SubtitleType.DelinquentHmm,
				new AudioClipArrayWrapper(DelinquentHmmClips)
			},
			{
				SubtitleType.DelinquentGrudge,
				new AudioClipArrayWrapper(DelinquentGrudgeClips)
			},
			{
				SubtitleType.Dismissive,
				new AudioClipArrayWrapper(DismissiveClips)
			},
			{
				SubtitleType.EvilDelinquentCorpseReaction,
				new AudioClipArrayWrapper(EvilDelinquentCorpseReactionClips)
			}
		};
	}

	private void Start()
	{
		Label.text = string.Empty;
	}

	private string GetRandomString(string[] strings)
	{
		return strings[Random.Range(0, strings.Length)];
	}

	public void UpdateLabel(SubtitleType subtitleType, int ID, float Duration)
	{
		switch (subtitleType)
		{
		case SubtitleType.WeaponAndBloodAndInsanityReaction:
			Label.text = GetRandomString(WeaponBloodInsanityReactions);
			break;
		case SubtitleType.WeaponAndBloodReaction:
			Label.text = GetRandomString(WeaponBloodReactions);
			break;
		case SubtitleType.WeaponAndInsanityReaction:
			Label.text = GetRandomString(WeaponInsanityReactions);
			break;
		case SubtitleType.BloodAndInsanityReaction:
			Label.text = GetRandomString(BloodInsanityReactions);
			break;
		case SubtitleType.WeaponReaction:
			switch (ID)
			{
			case 1:
				Label.text = GetRandomString(KnifeReactions);
				break;
			case 2:
				Label.text = GetRandomString(KatanaReactions);
				break;
			case 3:
				Label.text = GetRandomString(SyringeReactions);
				break;
			case 7:
				Label.text = GetRandomString(SawReactions);
				break;
			case 8:
				Label.text = GetRandomString(RitualReactions);
				break;
			case 9:
				Label.text = GetRandomString(BatReactions);
				break;
			case 10:
				Label.text = GetRandomString(ShovelReactions);
				break;
			case 11:
			case 14:
			case 16:
			case 17:
			case 22:
				Label.text = GetRandomString(PropReactions);
				break;
			case 12:
				Label.text = GetRandomString(DumbbellReactions);
				break;
			case 13:
			case 15:
				Label.text = GetRandomString(AxeReactions);
				break;
			case 18:
			case 19:
			case 20:
			case 21:
				Label.text = GetRandomString(DelinkWeaponReactions);
				break;
			}
			break;
		case SubtitleType.BloodReaction:
			Label.text = GetRandomString(BloodReactions);
			break;
		case SubtitleType.WetBloodReaction:
			Label.text = GetRandomString(WetBloodReactions);
			break;
		case SubtitleType.InsanityReaction:
			Label.text = GetRandomString(InsanityReactions);
			break;
		case SubtitleType.LewdReaction:
			Label.text = GetRandomString(LewdReactions);
			break;
		case SubtitleType.SuspiciousReaction:
			Label.text = GetRandomString(SuspiciousReactions);
			break;
		case SubtitleType.PrankReaction:
			Label.text = GetRandomString(PrankReactions);
			break;
		case SubtitleType.InterruptionReaction:
			Label.text = GetRandomString(InterruptReactions);
			break;
		case SubtitleType.IntrusionReaction:
			Label.text = GetRandomString(IntrusionReactions);
			break;
		case SubtitleType.KilledMood:
			Label.text = GetRandomString(KilledMoods);
			break;
		case SubtitleType.NoteReaction:
			Label.text = NoteReactions[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.AcceptFood:
			Label.text = GetRandomString(FoodAccepts);
			break;
		case SubtitleType.RejectFood:
			Label.text = FoodRejects[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.EavesdropReaction:
			RandomID = Random.Range(0, EavesdropReactions.Length);
			Label.text = EavesdropReactions[RandomID];
			break;
		case SubtitleType.ViolenceReaction:
			RandomID = Random.Range(0, ViolenceReactions.Length);
			Label.text = ViolenceReactions[RandomID];
			break;
		case SubtitleType.EventEavesdropReaction:
			RandomID = Random.Range(0, EventEavesdropReactions.Length);
			Label.text = EventEavesdropReactions[RandomID];
			break;
		case SubtitleType.RivalEavesdropReaction:
			RandomID = Random.Range(0, RivalEavesdropReactions.Length);
			Label.text = RivalEavesdropReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.PickpocketReaction:
			RandomID = Random.Range(0, PickpocketReactions.Length);
			Label.text = PickpocketReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.PickpocketApology:
			RandomID = Random.Range(0, PickpocketApologies.Length);
			Label.text = PickpocketApologies[RandomID];
			break;
		case SubtitleType.RivalPickpocketReaction:
			RandomID = Random.Range(0, RivalPickpocketReactions.Length);
			Label.text = RivalPickpocketReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DrownReaction:
			RandomID = Random.Range(0, DrownReactions.Length);
			Label.text = DrownReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.HmmReaction:
			if (Label.text == string.Empty)
			{
				RandomID = Random.Range(0, HmmReactions.Length);
				Label.text = HmmReactions[RandomID];
			}
			break;
		case SubtitleType.TeacherWeaponReaction:
			RandomID = Random.Range(0, TeacherWeaponReactions.Length);
			Label.text = TeacherWeaponReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherBloodReaction:
			RandomID = Random.Range(0, TeacherBloodReactions.Length);
			Label.text = TeacherBloodReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherInsanityReaction:
			RandomID = Random.Range(0, TeacherInsanityReactions.Length);
			Label.text = TeacherInsanityReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherWeaponHostile:
			RandomID = Random.Range(0, TeacherWeaponHostiles.Length);
			Label.text = TeacherWeaponHostiles[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherBloodHostile:
			RandomID = Random.Range(0, TeacherBloodHostiles.Length);
			Label.text = TeacherBloodHostiles[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherInsanityHostile:
			RandomID = Random.Range(0, TeacherInsanityHostiles.Length);
			Label.text = TeacherInsanityHostiles[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherLewdReaction:
			RandomID = Random.Range(0, TeacherLewdReactions.Length);
			Label.text = TeacherLewdReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherTrespassingReaction:
			RandomID = Random.Range(0, TeacherTrespassReactions.Length);
			Label.text = TeacherTrespassReactions[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.TeacherLateReaction:
			RandomID = Random.Range(0, TeacherLateReactions.Length);
			Label.text = TeacherLateReactions[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.TeacherReportReaction:
			RandomID = Random.Range(0, TeacherReportReactions.Length);
			Label.text = TeacherReportReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherCorpseReaction:
			RandomID = Random.Range(0, TeacherCorpseReactions.Length);
			Label.text = TeacherCorpseReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherCorpseInspection:
			Label.text = TeacherCorpseInspections[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.TeacherPoliceReport:
			RandomID = Random.Range(0, TeacherPoliceReports.Length);
			Label.text = TeacherPoliceReports[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherAttackReaction:
			RandomID = Random.Range(0, TeacherAttackReactions.Length);
			Label.text = TeacherAttackReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherMurderReaction:
			Label.text = TeacherMurderReactions[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.TeacherPrankReaction:
			RandomID = Random.Range(0, TeacherPrankReactions.Length);
			Label.text = TeacherPrankReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.TeacherTheftReaction:
			RandomID = Random.Range(0, TeacherTheftReactions.Length);
			Label.text = TeacherTheftReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentAnnoy:
			Label.text = DelinquentAnnoys[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.DelinquentCase:
			Label.text = DelinquentCases[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.DelinquentShove:
			RandomID = Random.Range(0, DelinquentShoves.Length);
			Label.text = DelinquentShoves[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentReaction:
			RandomID = Random.Range(0, DelinquentReactions.Length);
			Label.text = DelinquentReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentWeaponReaction:
			RandomID = Random.Range(0, DelinquentWeaponReactions.Length);
			Label.text = DelinquentWeaponReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentThreatened:
			RandomID = Random.Range(0, DelinquentThreateneds.Length);
			Label.text = DelinquentThreateneds[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentTaunt:
			RandomID = Random.Range(0, DelinquentTaunts.Length);
			Label.text = DelinquentTaunts[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentCalm:
			RandomID = Random.Range(0, DelinquentCalms.Length);
			Label.text = DelinquentCalms[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentFight:
			RandomID = Random.Range(0, DelinquentFights.Length);
			Label.text = DelinquentFights[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentAvenge:
			RandomID = Random.Range(0, DelinquentAvenges.Length);
			Label.text = DelinquentAvenges[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentWin:
			RandomID = Random.Range(0, DelinquentWins.Length);
			Label.text = DelinquentWins[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentSurrender:
			RandomID = Random.Range(0, DelinquentSurrenders.Length);
			Label.text = DelinquentSurrenders[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentNoSurrender:
			RandomID = Random.Range(0, DelinquentNoSurrenders.Length);
			Label.text = DelinquentNoSurrenders[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentMurderReaction:
			RandomID = Random.Range(0, DelinquentMurderReactions.Length);
			Label.text = DelinquentMurderReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentCorpseReaction:
			RandomID = Random.Range(0, DelinquentCorpseReactions.Length);
			Label.text = DelinquentCorpseReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentFriendCorpseReaction:
			RandomID = Random.Range(0, DelinquentFriendCorpseReactions.Length);
			Label.text = DelinquentFriendCorpseReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentResume:
			RandomID = Random.Range(0, DelinquentResumes.Length);
			Label.text = DelinquentResumes[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentFlee:
			RandomID = Random.Range(0, DelinquentFlees.Length);
			Label.text = DelinquentFlees[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentEnemyFlee:
			RandomID = Random.Range(0, DelinquentEnemyFlees.Length);
			Label.text = DelinquentEnemyFlees[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentFriendFlee:
			RandomID = Random.Range(0, DelinquentFriendFlees.Length);
			Label.text = DelinquentFriendFlees[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentInjuredFlee:
			RandomID = Random.Range(0, DelinquentInjuredFlees.Length);
			Label.text = DelinquentInjuredFlees[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentCheer:
			RandomID = Random.Range(0, DelinquentCheers.Length);
			Label.text = DelinquentCheers[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.DelinquentHmm:
			if (Label.text == string.Empty)
			{
				RandomID = Random.Range(0, DelinquentHmms.Length);
				Label.text = DelinquentHmms[RandomID];
				PlayVoice(subtitleType, RandomID);
			}
			break;
		case SubtitleType.DelinquentGrudge:
			RandomID = Random.Range(0, DelinquentGrudges.Length);
			Label.text = DelinquentGrudges[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.Dismissive:
			Label.text = Dismissives[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.LostPhone:
			Label.text = LostPhones[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.RivalLostPhone:
			Label.text = RivalLostPhones[ID];
			PlayVoice(subtitleType, ID);
			break;
		case SubtitleType.MurderReaction:
			Label.text = GetRandomString(MurderReactions);
			break;
		case SubtitleType.CorpseReaction:
			Label.text = GetRandomString(CorpseReactions);
			break;
		case SubtitleType.CouncilCorpseReaction:
			Label.text = CouncilCorpseReactions[ID];
			break;
		case SubtitleType.LonerMurderReaction:
			Label.text = GetRandomString(LonerMurderReactions);
			break;
		case SubtitleType.LonerCorpseReaction:
			Label.text = GetRandomString(LonerCorpseReactions);
			break;
		case SubtitleType.PetMurderReport:
			Label.text = PetMurderReports[ID];
			break;
		case SubtitleType.PetMurderReaction:
			Label.text = GetRandomString(PetMurderReactions);
			break;
		case SubtitleType.PetCorpseReport:
			Label.text = PetCorpseReports[ID];
			break;
		case SubtitleType.PetCorpseReaction:
			Label.text = GetRandomString(PetCorpseReactions);
			break;
		case SubtitleType.EvilCorpseReaction:
			Label.text = GetRandomString(EvilCorpseReactions);
			break;
		case SubtitleType.EvilDelinquentCorpseReaction:
			RandomID = Random.Range(0, EvilDelinquentCorpseReactions.Length);
			Label.text = EvilDelinquentCorpseReactions[RandomID];
			PlayVoice(subtitleType, RandomID);
			break;
		case SubtitleType.HeroMurderReaction:
			Label.text = GetRandomString(HeroMurderReactions);
			break;
		case SubtitleType.CowardMurderReaction:
			Label.text = GetRandomString(CowardMurderReactions);
			break;
		case SubtitleType.EvilMurderReaction:
			Label.text = GetRandomString(EvilMurderReactions);
			break;
		case SubtitleType.SocialDeathReaction:
			Label.text = GetRandomString(SocialDeathReactions);
			break;
		case SubtitleType.LovestruckDeathReaction:
			Label.text = GetRandomString(LovestruckDeathReactions);
			break;
		case SubtitleType.LovestruckMurderReport:
			Label.text = GetRandomString(LovestruckMurderReports);
			break;
		case SubtitleType.LovestruckCorpseReport:
			Label.text = GetRandomString(LovestruckCorpseReports);
			break;
		case SubtitleType.SocialReport:
			Label.text = GetRandomString(SocialReports);
			break;
		case SubtitleType.SocialFear:
			Label.text = GetRandomString(SocialFears);
			break;
		case SubtitleType.SocialTerror:
			Label.text = GetRandomString(SocialTerrors);
			break;
		case SubtitleType.RepeatReaction:
			Label.text = GetRandomString(RepeatReactions);
			break;
		case SubtitleType.Greeting:
			Label.text = GetRandomString(Greetings);
			break;
		case SubtitleType.PlayerFarewell:
			Label.text = GetRandomString(PlayerFarewells);
			break;
		case SubtitleType.StudentFarewell:
			Label.text = GetRandomString(StudentFarewells);
			break;
		case SubtitleType.InsanityApology:
			Label.text = GetRandomString(InsanityApologies);
			break;
		case SubtitleType.WeaponAndBloodApology:
			Label.text = GetRandomString(WeaponBloodApologies);
			break;
		case SubtitleType.WeaponApology:
			Label.text = GetRandomString(WeaponApologies);
			break;
		case SubtitleType.BloodApology:
			Label.text = GetRandomString(BloodApologies);
			break;
		case SubtitleType.LewdApology:
			Label.text = GetRandomString(LewdApologies);
			break;
		case SubtitleType.SuspiciousApology:
			Label.text = GetRandomString(SuspiciousApologies);
			break;
		case SubtitleType.EavesdropApology:
			Label.text = GetRandomString(EavesdropApologies);
			break;
		case SubtitleType.ViolenceApology:
			Label.text = GetRandomString(ViolenceApologies);
			break;
		case SubtitleType.EventApology:
			Label.text = GetRandomString(EventApologies);
			break;
		case SubtitleType.ClassApology:
			Label.text = GetRandomString(ClassApologies);
			break;
		case SubtitleType.AccidentApology:
			Label.text = GetRandomString(AccidentApologies);
			break;
		case SubtitleType.SadApology:
			Label.text = GetRandomString(SadApologies);
			break;
		default:
			switch (subtitleType)
			{
			case SubtitleType.Dismissive:
				Label.text = Dismissives[ID];
				break;
			case SubtitleType.Forgiving:
				Label.text = GetRandomString(Forgivings);
				break;
			case SubtitleType.ForgivingAccident:
				Label.text = GetRandomString(AccidentForgivings);
				break;
			case SubtitleType.ForgivingInsanity:
				Label.text = GetRandomString(InsanityForgivings);
				break;
			case SubtitleType.Impatience:
				Label.text = Impatiences[ID];
				break;
			case SubtitleType.PlayerCompliment:
				Label.text = GetRandomString(PlayerCompliments);
				break;
			case SubtitleType.StudentHighCompliment:
				Label.text = GetRandomString(StudentHighCompliments);
				break;
			case SubtitleType.StudentMidCompliment:
				Label.text = GetRandomString(StudentMidCompliments);
				break;
			case SubtitleType.StudentLowCompliment:
				Label.text = GetRandomString(StudentLowCompliments);
				break;
			case SubtitleType.PlayerGossip:
				Label.text = GetRandomString(PlayerGossip);
				break;
			case SubtitleType.StudentGossip:
				Label.text = GetRandomString(StudentGossip);
				break;
			case SubtitleType.PlayerFollow:
				Label.text = GetRandomString(PlayerFollows);
				break;
			case SubtitleType.StudentFollow:
				Label.text = GetRandomString(StudentFollows);
				break;
			case SubtitleType.PlayerLeave:
				Label.text = GetRandomString(PlayerLeaves);
				break;
			case SubtitleType.StudentLeave:
				Label.text = GetRandomString(StudentLeaves);
				break;
			case SubtitleType.StudentStay:
				Label.text = GetRandomString(StudentStays);
				break;
			case SubtitleType.PlayerDistract:
				Label.text = GetRandomString(PlayerDistracts);
				break;
			case SubtitleType.StudentDistract:
				Label.text = GetRandomString(StudentDistracts);
				break;
			case SubtitleType.StudentDistractRefuse:
				Label.text = GetRandomString(StudentDistractRefuses);
				break;
			case SubtitleType.StudentDistractBullyRefuse:
				Label.text = GetRandomString(StudentDistractBullyRefuses);
				break;
			case SubtitleType.StopFollowApology:
				Label.text = GetRandomString(StopFollowApologies);
				break;
			case SubtitleType.GrudgeWarning:
				Label.text = GetRandomString(GrudgeWarnings);
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.GrudgeRefusal:
				Label.text = GetRandomString(GrudgeRefusals);
				break;
			case SubtitleType.CowardGrudge:
				Label.text = GetRandomString(CowardGrudges);
				break;
			case SubtitleType.EvilGrudge:
				Label.text = GetRandomString(EvilGrudges);
				break;
			case SubtitleType.PlayerLove:
				Label.text = PlayerLove[ID];
				break;
			case SubtitleType.SuitorLove:
				Label.text = SuitorLove[ID];
				break;
			case SubtitleType.RivalLove:
				Label.text = RivalLove[ID];
				break;
			case SubtitleType.Dying:
				Label.text = GetRandomString(Deaths);
				break;
			case SubtitleType.SenpaiInsanityReaction:
				RandomID = Random.Range(0, SenpaiInsanityReactions.Length);
				Label.text = SenpaiInsanityReactions[RandomID];
				PlayVoice(subtitleType, RandomID);
				break;
			case SubtitleType.SenpaiWeaponReaction:
				RandomID = Random.Range(0, SenpaiWeaponReactions.Length);
				Label.text = SenpaiWeaponReactions[RandomID];
				PlayVoice(subtitleType, RandomID);
				break;
			case SubtitleType.SenpaiBloodReaction:
				RandomID = Random.Range(0, SenpaiBloodReactions.Length);
				Label.text = SenpaiBloodReactions[RandomID];
				PlayVoice(subtitleType, RandomID);
				break;
			case SubtitleType.SenpaiLewdReaction:
				Label.text = GetRandomString(SenpaiLewdReactions);
				PlayVoice(subtitleType, RandomID);
				break;
			case SubtitleType.SenpaiStalkingReaction:
				Label.text = SenpaiStalkingReactions[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.SenpaiMurderReaction:
				Label.text = SenpaiMurderReactions[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.SenpaiCorpseReaction:
				Label.text = GetRandomString(SenpaiCorpseReactions);
				break;
			case SubtitleType.SenpaiViolenceReaction:
				RandomID = Random.Range(0, SenpaiViolenceReactions.Length);
				Label.text = SenpaiViolenceReactions[RandomID];
				PlayVoice(subtitleType, RandomID);
				break;
			case SubtitleType.YandereWhimper:
				RandomID = Random.Range(0, YandereWhimpers.Length);
				Label.text = YandereWhimpers[RandomID];
				PlayVoice(subtitleType, RandomID);
				break;
			case SubtitleType.StudentMurderReport:
				Label.text = StudentMurderReports[ID];
				break;
			case SubtitleType.SplashReaction:
				Label.text = SplashReactions[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.RivalSplashReaction:
				Label.text = RivalSplashReactions[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.LightSwitchReaction:
				Label.text = LightSwitchReactions[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.PhotoAnnoyance:
				RandomID = Random.Range(0, PhotoAnnoyances.Length);
				Label.text = PhotoAnnoyances[RandomID];
				break;
			case SubtitleType.Task6Line:
				Label.text = Task6Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.Task7Line:
				Label.text = Task7Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.Task13Line:
				Label.text = Task13Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.Task14Line:
				Label.text = Task14Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.Task15Line:
				Label.text = Task15Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.Task32Line:
				Label.text = Task32Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.Task33Line:
				Label.text = Task33Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.Task34Line:
				Label.text = Task34Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.Task81Line:
				Label.text = Task81Lines[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubGreeting:
				Label.text = ClubGreetings[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubUnwelcome:
				Label.text = ClubUnwelcomes[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubKick:
				Label.text = ClubKicks[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubPlaceholderInfo:
				Label.text = Club0Info[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubOccultInfo:
				Label.text = Club3Info[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubArtInfo:
				Label.text = Club4Info[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubMartialArtsInfo:
				Label.text = Club6Info[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubPhotoInfoLight:
				Label.text = Club7InfoLight[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubPhotoInfoDark:
				Label.text = Club7InfoDark[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubScienceInfo:
				Label.text = Club8Info[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubSportsInfo:
				Label.text = Club9Info[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubGardenInfo:
				Label.text = Club10Info[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubJoin:
				Label.text = ClubJoins[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubAccept:
				Label.text = ClubAccepts[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubRefuse:
				Label.text = ClubRefuses[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubRejoin:
				Label.text = ClubRejoins[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubExclusive:
				Label.text = ClubExclusives[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubGrudge:
				Label.text = ClubGrudges[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubQuit:
				Label.text = ClubQuits[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubConfirm:
				Label.text = ClubConfirms[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubDeny:
				Label.text = ClubDenies[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubFarewell:
				Label.text = ClubFarewells[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubActivity:
				Label.text = ClubActivities[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubEarly:
				Label.text = ClubEarlies[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubLate:
				Label.text = ClubLates[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubYes:
				Label.text = ClubYeses[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.ClubNo:
				Label.text = ClubNoes[ID];
				PlayVoice(subtitleType, ID);
				break;
			case SubtitleType.InfoNotice:
				Label.text = InfoNotice;
				break;
			case SubtitleType.StrictReaction:
				Label.text = StrictReaction[ID];
				break;
			case SubtitleType.CasualReaction:
				Label.text = CasualReaction[ID];
				break;
			case SubtitleType.GraceReaction:
				Label.text = GraceReaction[ID];
				break;
			case SubtitleType.EdgyReaction:
				Label.text = EdgyReaction[ID];
				break;
			case SubtitleType.Shoving:
				Label.text = Shoving[ID];
				break;
			case SubtitleType.Spraying:
				Label.text = Spraying[ID];
				break;
			case SubtitleType.Chasing:
				Label.text = Chasing[ID];
				break;
			}
			break;
		}
		Timer = Duration;
	}

	private void Update()
	{
		if (Timer > 0f)
		{
			Timer -= Time.deltaTime;
			if (Timer <= 0f)
			{
				Jukebox.Dip = 1f;
				Label.text = string.Empty;
				Timer = 0f;
			}
		}
	}

	private void PlayVoice(SubtitleType subtitleType, int ID)
	{
		if (CurrentClip != null)
		{
		}
		Jukebox.Dip = 0.5f;
		AudioClipArrayWrapper value;
		bool flag = SubtitleClipArrays.TryGetValue(subtitleType, out value);
		PlayClip(value[ID], base.transform.position);
	}

	public float GetClipLength(int StudentID, int TaskPhase)
	{
		switch (StudentID)
		{
		case 6:
			return Task6Clips[TaskPhase].length;
		case 7:
			return Task7Clips[TaskPhase].length;
		case 13:
			return Task13Clips[TaskPhase].length;
		case 14:
			return Task14Clips[TaskPhase].length;
		case 15:
			return Task15Clips[TaskPhase].length;
		case 32:
			return Task32Clips[TaskPhase].length;
		case 33:
			return Task33Clips[TaskPhase].length;
		case 34:
			return Task34Clips[TaskPhase].length;
		case 81:
			return Task81Clips[TaskPhase].length;
		default:
			return 0f;
		}
	}

	public float GetClubClipLength(ClubType Club, int ClubPhase)
	{
		switch (Club)
		{
		case ClubType.Occult:
			return Club3Clips[ClubPhase].length + 0.5f;
		case ClubType.Art:
			return Club4Clips[ClubPhase].length + 0.5f;
		case ClubType.MartialArts:
			return Club6Clips[ClubPhase].length + 0.5f;
		case ClubType.Photography:
			if (SchoolGlobals.SchoolAtmosphere <= 0.8f)
			{
				return Club7ClipsDark[ClubPhase].length + 0.5f;
			}
			return Club7ClipsLight[ClubPhase].length + 0.5f;
		case ClubType.Science:
			return Club8Clips[ClubPhase].length + 0.5f;
		case ClubType.Sports:
			return Club9Clips[ClubPhase].length + 0.5f;
		case ClubType.Gardening:
			return Club10Clips[ClubPhase].length + 0.5f;
		default:
			return 0f;
		}
	}

	private void PlayClip(AudioClip clip, Vector3 pos)
	{
		if (clip != null)
		{
			GameObject gameObject = new GameObject("TempAudio");
			gameObject.transform.position = Yandere.transform.position + base.transform.up;
			gameObject.transform.parent = Yandere.transform;
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.clip = clip;
			audioSource.Play();
			Object.Destroy(gameObject, clip.length);
			audioSource.rolloffMode = AudioRolloffMode.Linear;
			audioSource.minDistance = 5f;
			audioSource.maxDistance = 10f;
			CurrentClip = gameObject;
			audioSource.volume = ((!(Yandere.position.y < gameObject.transform.position.y - 2f)) ? 1f : 0f);
		}
	}
}
