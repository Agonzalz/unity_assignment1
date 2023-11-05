using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    
    //when clicking the save button
    public static void Save() 
    {
        SaveSystem.SaveJson(new PlayerStats(SceneManager.GetActiveScene().name));

    }

    

    void Start()
    {
    }
    
}