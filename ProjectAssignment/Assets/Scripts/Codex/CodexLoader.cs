using System.IO;
using UnityEngine;

public class CodexLoader : MonoBehaviour
{
    public string jsonFileName = "codexData";
    public CodexRoot codexData;

    void Awake()
    {
        LoadCodexData();
    }

    void LoadCodexData()
    {
        string path = Path.Combine(Application.dataPath, "JSON", jsonFileName + ".json");

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            codexData = JsonUtility.FromJson<CodexRoot>(json);
            Debug.Log("Codex data loaded successfully.");
        }
        else
        {
            Debug.LogError("Codex JSON file not found at path: " + path);
        }
    }
}
