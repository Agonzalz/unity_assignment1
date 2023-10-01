using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTrigger : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "GolfBall") {
            Debug.Log("collison");
            //placeholder for where stage transition will be called. 
            //other.gameObject.transform.position = new Vector2(0,0);
            SceneManager.LoadScene(sceneName: "Hole 2");
        }
    }

}
