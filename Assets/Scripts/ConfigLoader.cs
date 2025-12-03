// ConfigLoader.cs
using UnityEngine;
using System.IO;

public class ConfigLoader : MonoBehaviour
{
    public GameConfig config;

    private void Awake()
    {
        LoadConfig();
    }

    public void LoadConfig()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "doofus_config.json");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            config = JsonUtility.FromJson<GameConfig>(json);
            Debug.Log($"Config loaded: playerSpeed={config.playerSpeed}, pulpitSize={config.pulpitSize}");
        }
        else
        {
            Debug.LogWarning("Config file not found at " + path + ". Using defaults.");
            config = new GameConfig();
        }
    }
}
