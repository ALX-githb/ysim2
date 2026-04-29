using UnityEngine;
using Better.StreamingAssets;
using UnityEngine.SceneManagement;

public class JsonScript : MonoBehaviour
{
    [SerializeField]
    private StudentJson[] students;

    [SerializeField]
    private CreditJson[] credits;

    [SerializeField]
    private TopicJson[] topics;

    public StudentJson[] Students => students;

    public CreditJson[] Credits => credits;

    public TopicJson[] Topics => topics;

    private void Start()
    {
        try
        {
            // Initialisation de Better Streaming Assets
            BetterStreamingAssets.Initialize();

            // Charger les étudiants
            students = StudentJson.LoadFromJson("Students.json");
            if (students == null)
            {
                Debug.LogError("[JsonScript] Students.json failed to load — creating empty fallback array.");
                students = new StudentJson[101];
                for (int i = 0; i < students.Length; i++)
                    students[i] = new StudentJson();
            }

            // Vérifier la scène actuelle pour charger les données appropriées
            if (SceneManager.GetActiveScene().name == "SchoolScene")
            {
                topics = TopicJson.LoadFromJson("Topics.json");
                StudentManagerScript studentManagerScript = Object.FindAnyObjectByType<StudentManagerScript>();
                if (studentManagerScript != null)
                    ReplaceDeadTeachers(studentManagerScript.FirstNames, studentManagerScript.LastNames);
                else
                    Debug.LogWarning("[JsonScript] StudentManagerScript not found in scene.");
            }
            else if (SceneManager.GetActiveScene().name == "CreditsScene")
            {
                credits = CreditJson.LoadFromJson("Credits.json");
            }
        }
        catch (System.Exception ex)
        {
            Debug.LogError("[JsonScript] Start failed: " + ex);
            if (students == null)
            {
                students = new StudentJson[101];
                for (int i = 0; i < students.Length; i++)
                    students[i] = new StudentJson();
            }
        }
    }

    private void ReplaceDeadTeachers(string[] firstNames, string[] lastNames)
    {
        for (int i = 90; i < 101; i++)
        {
            if (StudentGlobals.GetStudentDead(i))
            {
                // Remplacement des enseignants décédés
                StudentGlobals.SetStudentReplaced(i, true);
                StudentGlobals.SetStudentDead(i, false);

                // Générer un nouveau nom
                string value = firstNames[Random.Range(0, firstNames.Length)] + " " + lastNames[Random.Range(0, lastNames.Length)];
                StudentGlobals.SetStudentName(i, value);

                // Générer des caractéristiques aléatoires
                StudentGlobals.SetStudentBustSize(i, Random.Range(1f, 1.5f));
                StudentGlobals.SetStudentHairstyle(i, Random.Range(1, 8).ToString());

                // Générer des couleurs aléatoires
                Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                StudentGlobals.SetStudentColor(i, randomColor);

                randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                StudentGlobals.SetStudentEyeColor(i, randomColor);

                // Générer un accessoire aléatoire
                StudentGlobals.SetStudentAccessory(i, Random.Range(1, 7).ToString());
            }
        }

        // Mettre à jour les données des étudiants remplacés
        for (int j = 90; j < 101; j++)
        {
            if (StudentGlobals.GetStudentReplaced(j))
            {
                StudentJson studentJson = students[j];
                studentJson.Name = StudentGlobals.GetStudentName(j);
                studentJson.BreastSize = StudentGlobals.GetStudentBustSize(j);
                studentJson.Hairstyle = StudentGlobals.GetStudentHairstyle(j);
                studentJson.Accessory = StudentGlobals.GetStudentAccessory(j);

                // Assignations spécifiques pour certains étudiants
                if (j == 97)
                {
                    studentJson.Accessory = "7";
                }
                if (j == 90)
                {
                    studentJson.Accessory = "8";
                }
            }
        }
    }
}
