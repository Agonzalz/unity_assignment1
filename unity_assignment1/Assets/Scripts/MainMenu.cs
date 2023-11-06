using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Hole1");
    }

    //when pressing continue button
    public void Continue() 
    {
        PlayerStats player;
        player = SaveSystem.LoadJson();
        if(player != null) {
            SceneManager.LoadScene(player.current_level);
        }
    }
    public void Level() 
    {
        SceneManager.LoadScene("levels");
    }

     public void Options()
    {
        SceneManager.LoadScene("settings");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }

    public void Intro() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
