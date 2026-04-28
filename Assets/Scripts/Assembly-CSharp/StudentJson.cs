using System;
using System.Collections.Generic;
using System.IO;
using JsonFx.Json;
using UnityEngine;
using Better.StreamingAssets;

[Serializable]
public class StudentJson : JsonData
{
    [SerializeField]
    private string name;

    [SerializeField]
    private int gender;

    [SerializeField]
    private int classID;

    [SerializeField]
    private int seat;

    [SerializeField]
    private ClubType club;

    [SerializeField]
    private PersonaType persona;

    [SerializeField]
    private int crush;

    [SerializeField]
    private float breastSize;

    [SerializeField]
    private int strength;

    [SerializeField]
    private string hairstyle;

    [SerializeField]
    private string color;

    [SerializeField]
    private string eyes;

    [SerializeField]
    private string eyeType;

    [SerializeField]
    private string stockings;

    [SerializeField]
    private string accessory;

    [SerializeField]
    private string info;

    [SerializeField]
    private ScheduleBlock[] scheduleBlocks;

    [SerializeField]
    private bool success;

    public static string FilePath => Path.Combine(JsonData.FolderPath, "Students.json");

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Gender => gender;

    public int Class
    {
        get => classID;
        set => classID = value;
    }

    public int Seat
    {
        get => seat;
        set => seat = value;
    }

    public ClubType Club => club;

    public PersonaType Persona
    {
        get => persona;
        set => persona = value;
    }

    public int Crush => crush;

    public float BreastSize
    {
        get => breastSize;
        set => breastSize = value;
    }

    public int Strength
    {
        get => strength;
        set => strength = value;
    }

    public string Hairstyle
    {
        get => hairstyle;
        set => hairstyle = value;
    }

    public string Color => color;

    public string Eyes => eyes;

    public string EyeType => eyeType;

    public string Stockings => stockings;

    public string Accessory
    {
        get => accessory;
        set => accessory = value;
    }

    public string Info => info;

    public ScheduleBlock[] ScheduleBlocks => scheduleBlocks;

    public bool Success => success;

    public static StudentJson[] LoadFromJson(string fileName)
    {
        try
        {
            // Initialize Better Streaming Assets (if not already initialized)
            BetterStreamingAssets.Initialize();

            // Read JSON file using Better Streaming Assets
            string filePath = Path.Combine(JsonData.FolderPath, fileName);
            string jsonContent = BetterStreamingAssets.ReadAllText(filePath);

            // Deserialize JSON data
            var data = JsonReader.Deserialize<Dictionary<string, object>[]>(jsonContent);

            // Parse and return the student data
            return ParseStudentData(data);
        }
        catch (Exception ex)
        {
            Debug.LogError($"Error loading JSON file: {ex.Message}");
            return null;
        }
    }

    private static StudentJson[] ParseStudentData(Dictionary<string, object>[] data)
    {
        StudentJson[] students = new StudentJson[101];
        for (int i = 0; i < students.Length; i++)
        {
            students[i] = new StudentJson();
        }

        // Predefined data for specific students
        var infoChan = students[0];
        infoChan.name = "Info-chan";
        infoChan.club = ClubType.Nemesis;
        infoChan.persona = PersonaType.Nemesis;
        infoChan.crush = 99;

        var nemesis = students[90];
        nemesis.name = "Info-chan";
        nemesis.club = ClubType.Nemesis;
        nemesis.persona = PersonaType.Nemesis;
        nemesis.crush = 99;

        // Parse the JSON data into StudentJson objects
        foreach (var entry in data)
        {
            int id = TFUtils.LoadInt(entry, "ID");
            if (id == 0)
                continue;

            var student = students[id];
            student.name = TFUtils.LoadString(entry, "Name");
            student.gender = TFUtils.LoadInt(entry, "Gender");
            student.classID = TFUtils.LoadInt(entry, "Class");
            student.seat = TFUtils.LoadInt(entry, "Seat");
            student.club = (ClubType)TFUtils.LoadInt(entry, "Club");
            student.persona = (PersonaType)TFUtils.LoadInt(entry, "Persona");
            student.crush = TFUtils.LoadInt(entry, "Crush");
            student.breastSize = TFUtils.LoadFloat(entry, "BreastSize");
            student.strength = TFUtils.LoadInt(entry, "Strength");
            student.hairstyle = TFUtils.LoadString(entry, "Hairstyle");
            student.color = TFUtils.LoadString(entry, "Color");
            student.eyes = TFUtils.LoadString(entry, "Eyes");
            student.eyeType = TFUtils.LoadString(entry, "EyeType");
            student.stockings = TFUtils.LoadString(entry, "Stockings");
            student.accessory = TFUtils.LoadString(entry, "Accessory");
            student.info = TFUtils.LoadString(entry, "Info");

            var times = ConstructTempFloatArray(TFUtils.LoadString(entry, "ScheduleTime"));
            var destinations = ConstructTempStringArray(TFUtils.LoadString(entry, "ScheduleDestination"));
            var actions = ConstructTempStringArray(TFUtils.LoadString(entry, "ScheduleAction"));

            student.scheduleBlocks = new ScheduleBlock[times.Length];
            for (int i = 0; i < student.scheduleBlocks.Length; i++)
            {
                student.scheduleBlocks[i] = new ScheduleBlock(times[i], destinations[i], actions[i]);
            }

            student.success = true;
        }

        return students;
    }

    private static float[] ConstructTempFloatArray(string str)
    {
        string[] parts = str.Split('_');
        float[] result = new float[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            result[i] = float.Parse(parts[i]);
        }
        return result;
    }

    private static string[] ConstructTempStringArray(string str)
    {
        return str.Split('_');
    }
}
