using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTrigger : MonoBehaviour
{
    public AudioSource audioPlayer;
    
    //Two second delay 
    public float delayTime = .25f;
    //GameObject.Find("GameMusic");
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "GolfBall") {
            Debug.Log("collison");
            audioPlayer.Play();
            //Delay Scene Switch to play music 
            Invoke("DelayedAction", delayTime);
            }
    }

    void DelayedAction(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
