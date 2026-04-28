using UnityEngine;

public static class DatingGlobals
{
	private const string Str_Affection = "Affection";

	private const string Str_AffectionLevel = "AffectionLevel";

	private const string Str_ComplimentGiven = "ComplimentGiven_";

	private const string Str_SuitorCheck = "SuitorCheck_";

	private const string Str_SuitorProgress = "SuitorProgress";

	private const string Str_SuitorTrait = "SuitorTrait_";

	private const string Str_TopicDiscussed = "TopicDiscussed_";

	private const string Str_TraitDemonstrated = "TraitDemonstrated_";

	private const string Str_RivalSabotaged = "RivalSabotaged";

	public static float Affection
	{
		get
		{
			return PlayerPrefs.GetFloat("Affection");
		}
		set
		{
			PlayerPrefs.SetFloat("Affection", value);
		}
	}

	public static float AffectionLevel
	{
		get
		{
			return PlayerPrefs.GetFloat("AffectionLevel");
		}
		set
		{
			PlayerPrefs.SetFloat("AffectionLevel", value);
		}
	}

	public static int SuitorProgress
	{
		get
		{
			return PlayerPrefs.GetInt("SuitorProgress");
		}
		set
		{
			PlayerPrefs.SetInt("SuitorProgress", value);
		}
	}

	public static int RivalSabotaged
	{
		get
		{
			return PlayerPrefs.GetInt("RivalSabotaged");
		}
		set
		{
			PlayerPrefs.SetInt("RivalSabotaged", value);
		}
	}

	public static bool GetComplimentGiven(int complimentID)
	{
		return GlobalsHelper.GetBool("ComplimentGiven_" + complimentID);
	}

	public static void SetComplimentGiven(int complimentID, bool value)
	{
		string text = complimentID.ToString();
		KeysHelper.AddIfMissing("ComplimentGiven_", text);
		GlobalsHelper.SetBool("ComplimentGiven_" + text, value);
	}

	public static int[] KeysOfComplimentGiven()
	{
		return KeysHelper.GetIntegerKeys("ComplimentGiven_");
	}

	public static bool GetSuitorCheck(int checkID)
	{
		return GlobalsHelper.GetBool("SuitorCheck_" + checkID);
	}

	public static void SetSuitorCheck(int checkID, bool value)
	{
		string text = checkID.ToString();
		KeysHelper.AddIfMissing("SuitorCheck_", text);
		GlobalsHelper.SetBool("SuitorCheck_" + text, value);
	}

	public static int[] KeysOfSuitorCheck()
	{
		return KeysHelper.GetIntegerKeys("SuitorCheck_");
	}

	public static int GetSuitorTrait(int traitID)
	{
		return PlayerPrefs.GetInt("SuitorTrait_" + traitID);
	}

	public static void SetSuitorTrait(int traitID, int value)
	{
		string text = traitID.ToString();
		KeysHelper.AddIfMissing("SuitorTrait_", text);
		PlayerPrefs.SetInt("SuitorTrait_" + text, value);
	}

	public static int[] KeysOfSuitorTrait()
	{
		return KeysHelper.GetIntegerKeys("SuitorTrait_");
	}

	public static bool GetTopicDiscussed(int topicID)
	{
		return GlobalsHelper.GetBool("TopicDiscussed_" + topicID);
	}

	public static void SetTopicDiscussed(int topicID, bool value)
	{
		string text = topicID.ToString();
		KeysHelper.AddIfMissing("TopicDiscussed_", text);
		GlobalsHelper.SetBool("TopicDiscussed_" + text, value);
	}

	public static int[] KeysOfTopicDiscussed()
	{
		return KeysHelper.GetIntegerKeys("TopicDiscussed_");
	}

	public static int GetTraitDemonstrated(int traitID)
	{
		return PlayerPrefs.GetInt("TraitDemonstrated_" + traitID);
	}

	public static void SetTraitDemonstrated(int traitID, int value)
	{
		string text = traitID.ToString();
		KeysHelper.AddIfMissing("TraitDemonstrated_", text);
		PlayerPrefs.SetInt("TraitDemonstrated_" + text, value);
	}

	public static int[] KeysOfTraitDemonstrated()
	{
		return KeysHelper.GetIntegerKeys("TraitDemonstrated_");
	}

	public static void DeleteAll()
	{
		Globals.Delete("Affection");
		Globals.Delete("AffectionLevel");
		Globals.DeleteCollection("ComplimentGiven_", KeysOfComplimentGiven());
		Globals.DeleteCollection("SuitorCheck_", KeysOfSuitorCheck());
		Globals.Delete("SuitorProgress");
		Globals.Delete("RivalSabotaged");
		Globals.DeleteCollection("SuitorTrait_", KeysOfSuitorTrait());
		Globals.DeleteCollection("TopicDiscussed_", KeysOfTopicDiscussed());
		Globals.DeleteCollection("TraitDemonstrated_", KeysOfTraitDemonstrated());
	}
}
