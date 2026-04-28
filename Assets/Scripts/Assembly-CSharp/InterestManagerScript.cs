using UnityEngine;

public class InterestManagerScript : MonoBehaviour
{
	public StudentManagerScript StudentManager;

	public YandereScript Yandere;

	public Transform MartialArts;

	public Transform OccultClub;

	public Transform VideoGames;

	public Transform Kitten;

	private void Update()
	{
		if (!(Yandere.Follower != null) || Yandere.Follower.StudentID != 7)
		{
			return;
		}
		if (!ConversationGlobals.GetTopicLearnedByStudent(3, 7) && Vector3.Distance(Yandere.Follower.transform.position, OccultClub.position) < 5f)
		{
			if (!ConversationGlobals.GetTopicDiscovered(3))
			{
				Yandere.NotificationManager.DisplayNotification(NotificationType.Topic);
				ConversationGlobals.SetTopicDiscovered(3, true);
			}
			Yandere.NotificationManager.DisplayNotification(NotificationType.Opinion);
			ConversationGlobals.SetTopicLearnedByStudent(3, 7, true);
		}
		if (!ConversationGlobals.GetTopicLearnedByStudent(14, 7))
		{
			StudentScript studentScript = StudentManager.Students[22];
			StudentScript studentScript2 = StudentManager.Students[24];
			StudentScript studentScript3 = StudentManager.Students[25];
			if (studentScript != null && studentScript3 != null && studentScript.Actions[studentScript.Phase] == StudentActionType.ClubAction && studentScript.DistanceToDestination < 1f && studentScript2.Actions[studentScript2.Phase] == StudentActionType.ClubAction && studentScript2.DistanceToDestination < 1f && Vector3.Distance(Yandere.Follower.transform.position, MartialArts.position) < 5f)
			{
				if (!ConversationGlobals.GetTopicDiscovered(14))
				{
					Yandere.NotificationManager.DisplayNotification(NotificationType.Topic);
					ConversationGlobals.SetTopicDiscovered(14, true);
				}
				Yandere.NotificationManager.DisplayNotification(NotificationType.Opinion);
				ConversationGlobals.SetTopicLearnedByStudent(14, 7, true);
			}
		}
		if (!ConversationGlobals.GetTopicLearnedByStudent(16, 7))
		{
			StudentScript studentScript4 = StudentManager.Students[22];
			StudentScript studentScript5 = StudentManager.Students[25];
			if (studentScript4 != null && studentScript5 != null && VideoGames.gameObject.activeInHierarchy && Vector3.Distance(Yandere.Follower.transform.position, VideoGames.position) < 2.5f)
			{
				if (!ConversationGlobals.GetTopicDiscovered(16))
				{
					Yandere.NotificationManager.DisplayNotification(NotificationType.Topic);
					ConversationGlobals.SetTopicDiscovered(16, true);
				}
				Yandere.NotificationManager.DisplayNotification(NotificationType.Opinion);
				ConversationGlobals.SetTopicLearnedByStudent(16, 7, true);
			}
		}
		if (!ConversationGlobals.GetTopicLearnedByStudent(20, 7) && Vector3.Distance(Yandere.Follower.transform.position, Kitten.position) < 2.5f)
		{
			if (!ConversationGlobals.GetTopicDiscovered(20))
			{
				Yandere.NotificationManager.DisplayNotification(NotificationType.Topic);
				ConversationGlobals.SetTopicDiscovered(20, true);
			}
			Yandere.NotificationManager.DisplayNotification(NotificationType.Opinion);
			ConversationGlobals.SetTopicLearnedByStudent(20, 7, true);
		}
	}
}
