using UnityEngine;
using System.IO;

public static class SaveSystem 
{
    public static void SaveJson(PlayerStats player)
    {
        string playerdata = JsonUtility.ToJson(player);
        string filepath = Application.persistentDataPath + "/playerstats.json";
        Debug.Log(filepath);
        File.WriteAllText(filepath, playerdata);
    }

    public static PlayerStats LoadJson()
    {
        if(File.Exists(Application.persistentDataPath+"/playerstats.json"))
        {
            return JsonUtility.FromJson<PlayerStats>(File.ReadAllText(Application.persistentDataPath+"/playerstats.json"));
        } else
        {
            Debug.LogError("Save file not found");
            return null;
        }
    
    }
}