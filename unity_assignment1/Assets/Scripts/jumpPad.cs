using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class speedBoost : MonoBehaviour
{
    public AudioSource audioPlayer;

    private float speed =7f;
    
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "GolfBall") {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            Debug.Log("collison");
            audioPlayer.Play();
            }
    }

}