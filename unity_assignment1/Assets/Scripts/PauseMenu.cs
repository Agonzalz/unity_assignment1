using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool ispaused = false;
    public GameObject pause_menu;
    
    
   public void Resume()
    {
        pause_menu.SetActive(false);
        Time.timeScale = 1;
        ispaused = false;
    }

    public void Pause()
    {
        pause_menu.SetActive(true);
        Time.timeScale = 0;
        ispaused = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused == true)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    //button actions
    public void Save_button() 
    {
        GameManager.Save();
    }

    public void Menu_button()
    {   
        Time.timeScale = 1;
        ispaused = false;
        Sceneswitcher.Mainmenu();
    } 

    public void Resume_button()
    {
        Resume();
    }

    public void Quit_button() 
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");

    }

    public void Pause_button()
    {
        Pause();
    }

}
