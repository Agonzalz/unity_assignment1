using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitcher : MonoBehaviour
{
    public void Level_1()
    {
        SceneManager.LoadScene("Hole1");
    }

    public void Level_2()
    {
        SceneManager.LoadScene("Hole2");
    }

    public void Level_3()
    {
        SceneManager.LoadScene("Hole3");
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }
}
