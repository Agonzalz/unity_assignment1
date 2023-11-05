using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitcher : MonoBehaviour
{
    public static void Level_1()
    {
        SceneManager.LoadScene("Hole1");
    }

    public static void Level_2()
    {
        SceneManager.LoadScene("Hole2");
    }

    public static void Level_3()
    {
        SceneManager.LoadScene("Hole3");
    }

    public static void Mainmenu()
    { 
        SceneManager.LoadScene("WelcomeScreen");
    }

}
