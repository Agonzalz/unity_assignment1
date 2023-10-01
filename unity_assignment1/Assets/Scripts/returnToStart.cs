using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToStart : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "GolfBall") {
            Debug.Log("collison");
            SceneManager.LoadScene(sceneName: "WelcomeScreen");
        }
    }

     
}