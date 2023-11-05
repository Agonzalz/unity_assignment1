using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public string current_level;
    public int max_level;

    public PlayerStats(string level)
    {
        current_level = level;
    }
}
