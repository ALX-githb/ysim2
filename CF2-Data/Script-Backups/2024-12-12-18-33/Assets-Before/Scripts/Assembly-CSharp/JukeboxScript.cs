using UnityEngine;

public class JukeboxScript : MonoBehaviour
{
	public YandereScript Yandere;

	public AudioSource SFX;

	public AudioSource AttackOnTitan;

	public AudioSource Megalovania;

	public AudioSource MissionMode;

	public AudioSource Skeletons;

	public AudioSource Metroid;

	public AudioSource Nuclear;

	public AudioSource Slender;

	public AudioSource Sukeban;

	public AudioSource Custom;

	public AudioSource Hatred;

	public AudioSource Hitman;

	public AudioSource Touhou;

	public AudioSource Falcon;

	public AudioSource Ebola;

	public AudioSource Demon;

	public AudioSource Ninja;

	public AudioSource Punch;

	public AudioSource Galo;

	public AudioSource Jojo;

	public AudioSource Sith;

	public AudioSource DK;

	public AudioSource Confession;

	public AudioSource FullSanity;

	public AudioSource HalfSanity;

	public AudioSource NoSanity;

	public AudioSource Chase;

	public float LastVolume;

	public float FadeSpeed;

	public float ClubDip;

	public float Volume;

	public int Track;

	public int BGM;

	public float Dip = 1f;

	public bool StartMusic;

	public bool Egg;

	public AudioClip[] FullSanities;

	public AudioClip[] HalfSanities;

	public AudioClip[] NoSanities;

	public AudioClip[] OriginalFull;

	public AudioClip[] OriginalHalf;

	public AudioClip[] OriginalNo;

	public AudioClip[] AlternateFull;

	public AudioClip[] AlternateHalf;

	public AudioClip[] AlternateNo;

	public AudioClip[] ThirdFull;

	public AudioClip[] ThirdHalf;

	public AudioClip[] ThirdNo;

	public AudioClip[] FourthFull;

	public AudioClip[] FourthHalf;

	public AudioClip[] FourthNo;

	public AudioClip[] FifthFull;

	public AudioClip[] FifthHalf;

	public AudioClip[] FifthNo;

	public AudioClip[] SixthFull;

	public AudioClip[] SixthHalf;

	public AudioClip[] SixthNo;

	public AudioClip[] SeventhFull;

	public AudioClip[] SeventhHalf;

	public AudioClip[] SeventhNo;

	private void Start()
	{
		if (BGM == 0)
		{
			BGM = Random.Range(0, 8);
		}
		else
		{
			BGM++;
			if (BGM > 7)
			{
				BGM = 1;
			}
		}
		if (BGM == 1)
		{
			FullSanities = OriginalFull;
			HalfSanities = OriginalHalf;
			NoSanities = OriginalNo;
		}
		else if (BGM == 2)
		{
			FullSanities = AlternateFull;
			HalfSanities = AlternateHalf;
			NoSanities = AlternateNo;
		}
		else if (BGM == 3)
		{
			FullSanities = ThirdFull;
			HalfSanities = ThirdHalf;
			NoSanities = ThirdNo;
		}
		else if (BGM == 4)
		{
			FullSanities = FourthFull;
			HalfSanities = FourthHalf;
			NoSanities = FourthNo;
		}
		else if (BGM == 5)
		{
			FullSanities = FifthFull;
			HalfSanities = FifthHalf;
			NoSanities = FifthNo;
		}
		else if (BGM == 6)
		{
			FullSanities = SixthFull;
			HalfSanities = SixthHalf;
			NoSanities = SixthNo;
		}
		else if (BGM == 7)
		{
			FullSanities = SeventhFull;
			HalfSanities = SeventhHalf;
			NoSanities = SeventhNo;
		}
		if (!SchoolGlobals.SchoolAtmosphereSet)
		{
			SchoolGlobals.SchoolAtmosphereSet = true;
			SchoolGlobals.SchoolAtmosphere = 1f;
		}
		int num = 0;
		num = ((SchoolAtmosphere.Type == SchoolAtmosphereType.High) ? 3 : ((SchoolAtmosphere.Type != SchoolAtmosphereType.Medium) ? 1 : 2));
		FullSanity.clip = FullSanities[num];
		HalfSanity.clip = HalfSanities[num];
		NoSanity.clip = NoSanities[num];
		Volume = 0.25f;
		FullSanity.volume = 0f;
		Hitman.time = 26f;
	}

	private void Update()
	{
		if (!Yandere.PauseScreen.Show && !Yandere.EasterEggMenu.activeInHierarchy)
		{
			if (Input.GetKeyDown(KeyCode.M))
			{
				if (Custom.isPlaying)
				{
					Egg = false;
					Custom.Stop();
				}
				if (Volume == 0f)
				{
					FadeSpeed = 1f;
					StartMusic = false;
					Volume = LastVolume;
					Start();
				}
				else
				{
					LastVolume = Volume;
					FadeSpeed = 10f;
					Volume = 0f;
				}
			}
			if (Input.GetKeyDown(KeyCode.N) && Volume < 1f)
			{
				Volume += 0.1f;
			}
			if (Input.GetKeyDown(KeyCode.B) && Volume > 0f)
			{
				Volume -= 0.1f;
			}
		}
		if (!Egg)
		{
			if (!Yandere.Police.Clock.SchoolBell.isPlaying)
			{
				if (!StartMusic)
				{
					FullSanity.Play();
					HalfSanity.Play();
					NoSanity.Play();
					StartMusic = true;
				}
				if (Yandere.Sanity >= 66.666664f)
				{
					FullSanity.volume = Mathf.MoveTowards(FullSanity.volume, Volume * Dip - ClubDip, Time.deltaTime * FadeSpeed);
					HalfSanity.volume = Mathf.MoveTowards(HalfSanity.volume, 0f, Time.deltaTime * FadeSpeed);
					NoSanity.volume = Mathf.MoveTowards(NoSanity.volume, 0f, Time.deltaTime * FadeSpeed);
				}
				else if (Yandere.Sanity >= 33.333332f)
				{
					FullSanity.volume = Mathf.MoveTowards(FullSanity.volume, 0f, Time.deltaTime * FadeSpeed);
					HalfSanity.volume = Mathf.MoveTowards(HalfSanity.volume, Volume * Dip - ClubDip, Time.deltaTime * FadeSpeed);
					NoSanity.volume = Mathf.MoveTowards(NoSanity.volume, 0f, Time.deltaTime * FadeSpeed);
				}
				else
				{
					FullSanity.volume = Mathf.MoveTowards(FullSanity.volume, 0f, Time.deltaTime * FadeSpeed);
					HalfSanity.volume = Mathf.MoveTowards(HalfSanity.volume, 0f, Time.deltaTime * FadeSpeed);
					NoSanity.volume = Mathf.MoveTowards(NoSanity.volume, Volume * Dip - ClubDip, Time.deltaTime * FadeSpeed);
				}
			}
		}
		else
		{
			AttackOnTitan.volume = Mathf.MoveTowards(AttackOnTitan.volume, Volume * Dip, Time.deltaTime * 10f);
			Megalovania.volume = Mathf.MoveTowards(Megalovania.volume, Volume * Dip, Time.deltaTime * 10f);
			MissionMode.volume = Mathf.MoveTowards(MissionMode.volume, Volume * Dip, Time.deltaTime * 10f);
			Skeletons.volume = Mathf.MoveTowards(Skeletons.volume, Volume * Dip, Time.deltaTime * 10f);
			Metroid.volume = Mathf.MoveTowards(Metroid.volume, Volume * Dip, Time.deltaTime * 10f);
			Nuclear.volume = Mathf.MoveTowards(Nuclear.volume, Volume * Dip, Time.deltaTime * 10f);
			Slender.volume = Mathf.MoveTowards(Slender.volume, Volume * Dip, Time.deltaTime * 10f);
			Sukeban.volume = Mathf.MoveTowards(Sukeban.volume, Volume * Dip, Time.deltaTime * 10f);
			Custom.volume = Mathf.MoveTowards(Custom.volume, Volume * Dip, Time.deltaTime * 10f);
			Hatred.volume = Mathf.MoveTowards(Hatred.volume, Volume * Dip, Time.deltaTime * 10f);
			Hitman.volume = Mathf.MoveTowards(Hitman.volume, Volume * Dip, Time.deltaTime * 10f);
			Touhou.volume = Mathf.MoveTowards(Touhou.volume, Volume * Dip, Time.deltaTime * 10f);
			Falcon.volume = Mathf.MoveTowards(Falcon.volume, Volume * Dip, Time.deltaTime * 10f);
			Demon.volume = Mathf.MoveTowards(Demon.volume, Volume * Dip, Time.deltaTime * 10f);
			Ebola.volume = Mathf.MoveTowards(Ebola.volume, Volume * Dip, Time.deltaTime * 10f);
			Ninja.volume = Mathf.MoveTowards(Ninja.volume, Volume * Dip, Time.deltaTime * 10f);
			Punch.volume = Mathf.MoveTowards(Punch.volume, Volume * Dip, Time.deltaTime * 10f);
			Galo.volume = Mathf.MoveTowards(Galo.volume, Volume * Dip, Time.deltaTime * 10f);
			Jojo.volume = Mathf.MoveTowards(Jojo.volume, Volume * Dip, Time.deltaTime * 10f);
			Sith.volume = Mathf.MoveTowards(Sith.volume, Volume * Dip, Time.deltaTime * 10f);
			DK.volume = Mathf.MoveTowards(DK.volume, Volume * Dip, Time.deltaTime * 10f);
		}
		if (!Yandere.PauseScreen.Show && !Yandere.Noticed && Yandere.CanMove && Yandere.EasterEggMenu.activeInHierarchy && !Egg)
		{
			if (Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.Alpha4))
			{
				Egg = true;
				KillVolume();
				AttackOnTitan.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.P))
			{
				Egg = true;
				KillVolume();
				Nuclear.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.H))
			{
				Egg = true;
				KillVolume();
				Hatred.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.B))
			{
				Egg = true;
				KillVolume();
				Sukeban.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Z))
			{
				Egg = true;
				KillVolume();
				Slender.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.G))
			{
				Egg = true;
				KillVolume();
				Galo.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.L))
			{
				Egg = true;
				KillVolume();
				Hitman.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.S))
			{
				Egg = true;
				KillVolume();
				Skeletons.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.K))
			{
				Egg = true;
				KillVolume();
				DK.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.C))
			{
				Egg = true;
				KillVolume();
				Touhou.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.F))
			{
				Egg = true;
				KillVolume();
				Falcon.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.O))
			{
				Egg = true;
				KillVolume();
				Punch.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.U))
			{
				Egg = true;
				KillVolume();
				Megalovania.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.Q))
			{
				Egg = true;
				KillVolume();
				Metroid.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.Y))
			{
				Egg = true;
				KillVolume();
				Ninja.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha7))
			{
				Egg = true;
				KillVolume();
				Ebola.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha6))
			{
				Egg = true;
				KillVolume();
				Demon.enabled = true;
			}
			else if (Input.GetKeyDown(KeyCode.D))
			{
				Egg = true;
				KillVolume();
				Sith.enabled = true;
			}
		}
	}

	public void KillVolume()
	{
		FullSanity.volume = 0f;
		HalfSanity.volume = 0f;
		NoSanity.volume = 0f;
		Volume = 0.5f;
	}

	public void GameOver()
	{
		AttackOnTitan.Stop();
		Megalovania.Stop();
		MissionMode.Stop();
		Skeletons.Stop();
		Metroid.Stop();
		Nuclear.Stop();
		Sukeban.Stop();
		Custom.Stop();
		Slender.Stop();
		Hatred.Stop();
		Hitman.Stop();
		Touhou.Stop();
		Falcon.Stop();
		Ebola.Stop();
		Punch.Stop();
		Ninja.Stop();
		Galo.Stop();
		Sith.Stop();
		DK.Stop();
		Confession.Stop();
		FullSanity.Stop();
		HalfSanity.Stop();
		NoSanity.Stop();
	}

	public void PlayJojo()
	{
		Egg = true;
		KillVolume();
		Jojo.enabled = true;
	}

	public void PlayCustom()
	{
		Egg = true;
		KillVolume();
		Custom.enabled = true;
		Custom.Play();
	}
}
