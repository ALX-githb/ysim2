public static class ClubGlobals
{
	private const string Str_Club = "Club";

	private const string Str_ClubClosed = "ClubClosed_";

	private const string Str_ClubKicked = "ClubKicked_";

	private const string Str_QuitClub = "QuitClub_";

	public static ClubType Club
	{
		get
		{
			return GlobalsHelper.GetEnum<ClubType>("Club");
		}
		set
		{
			GlobalsHelper.SetEnum("Club", value);
		}
	}

	public static bool GetClubClosed(ClubType clubID)
	{
		int num = (int)clubID;
		return GlobalsHelper.GetBool("ClubClosed_" + num);
	}

	public static void SetClubClosed(ClubType clubID, bool value)
	{
		int num = (int)clubID;
		string text = num.ToString();
		KeysHelper.AddIfMissing("ClubClosed_", text);
		GlobalsHelper.SetBool("ClubClosed_" + text, value);
	}

	public static ClubType[] KeysOfClubClosed()
	{
		return KeysHelper.GetEnumKeys<ClubType>("ClubClosed_");
	}

	public static bool GetClubKicked(ClubType clubID)
	{
		int num = (int)clubID;
		return GlobalsHelper.GetBool("ClubKicked_" + num);
	}

	public static void SetClubKicked(ClubType clubID, bool value)
	{
		int num = (int)clubID;
		string text = num.ToString();
		KeysHelper.AddIfMissing("ClubKicked_", text);
		GlobalsHelper.SetBool("ClubKicked_" + text, value);
	}

	public static ClubType[] KeysOfClubKicked()
	{
		return KeysHelper.GetEnumKeys<ClubType>("ClubKicked_");
	}

	public static bool GetQuitClub(ClubType clubID)
	{
		int num = (int)clubID;
		return GlobalsHelper.GetBool("QuitClub_" + num);
	}

	public static void SetQuitClub(ClubType clubID, bool value)
	{
		int num = (int)clubID;
		string text = num.ToString();
		KeysHelper.AddIfMissing("QuitClub_", text);
		GlobalsHelper.SetBool("QuitClub_" + text, value);
	}

	public static ClubType[] KeysOfQuitClub()
	{
		return KeysHelper.GetEnumKeys<ClubType>("QuitClub_");
	}

	public static void DeleteAll()
	{
		Globals.Delete("Club");
		ClubType[] array = KeysOfClubClosed();
		foreach (ClubType clubType in array)
		{
			int num = (int)clubType;
			Globals.Delete("ClubClosed_" + num);
		}
		ClubType[] array2 = KeysOfClubKicked();
		foreach (ClubType clubType2 in array2)
		{
			int num2 = (int)clubType2;
			Globals.Delete("ClubKicked_" + num2);
		}
		ClubType[] array3 = KeysOfQuitClub();
		foreach (ClubType clubType3 in array3)
		{
			int num3 = (int)clubType3;
			Globals.Delete("QuitClub_" + num3);
		}
		KeysHelper.Delete("ClubClosed_");
		KeysHelper.Delete("ClubKicked_");
		KeysHelper.Delete("QuitClub_");
	}
}
