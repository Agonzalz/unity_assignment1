using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    [SerializeField] Vector2 startposition;
     Quaternion defrotation;
    //amount of frames that the ball has stopped
    float timestopped = 0;
    Rigidbody2D rigidb;
    // Start is called before the first frame update
    void Start()
    {
        rigidb = GetComponent<Rigidbody2D>();
        startposition = (Vector2)transform.position;
        defrotation = transform.rotation;
    }

    //check if ball has stopped for a certain amount of frames
    bool Stopped() {
      if (rigidb.velocity.magnitude <= 0.1f){
        timestopped += 1f;
        return true;
      }else {
        return false;
      }
   }   

   void OnBecameInvisible()
   {
    transform.position = startposition;
    transform.rotation = defrotation;
    rigidb.velocity = new Vector2(0, 0);
    timestopped = 0;
   }


    // Update is called once per frame
    void Update()
    {
        if (Stopped() && timestopped == 1000f) {
           rigidb.velocity = new Vector2(0, 0);
           transform.rotation = defrotation;
           rigidb.velocity = new Vector2(0, 0);
           transform.position = startposition;
           timestopped = 0;
        }
    }
}
