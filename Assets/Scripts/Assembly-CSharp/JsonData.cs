using System.Collections.Generic;
using System.IO;
using JsonFx.Json;
using UnityEngine;
using Better.StreamingAssets;

public abstract class JsonData
{
    protected static string FolderPath => "JSON";

    protected static Dictionary<string, object>[] Deserialize(string filename)
    {
        string filePath = Path.Combine(FolderPath, filename);
        string jsonContent = BetterStreamingAssets.ReadAllText(filePath);
        return JsonReader.Deserialize<Dictionary<string, object>[]>(jsonContent);
    }
}