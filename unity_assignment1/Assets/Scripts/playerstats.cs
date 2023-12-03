using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public int attempts;
    public string current_level;
    public int max_level;

    public PlayerStats(string level, int tries)
    {
        current_level = level;
        attempts = tries;
    }
}
