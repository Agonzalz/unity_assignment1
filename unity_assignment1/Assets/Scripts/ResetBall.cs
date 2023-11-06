using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    public bool at_goal = false;
    [SerializeField] private Vector2 startposition;
    [SerializeField] private float max_frames = 1000f;
    //amount of frames that the ball has stopped
    private float timestopped = 0;
    private Rigidbody2D rigidb;
    // Start is called before the first frame update
    void Start()
    {
        rigidb = GetComponent<Rigidbody2D>();
        startposition = (Vector2)transform.position;
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
    //transform.rotation = defrotation;
    rigidb.velocity = Vector3.zero;
    rigidb.angularVelocity = 0;
    timestopped = 0;
    transform.position = startposition;
    
   }

   void OnCollisionEnter2D(Collision2D other)
   {
    if (other.gameObject.name == "Goal") 
    {
      at_goal = true;
    }
   }

   public void Reset() 
   {  
      rigidb.velocity = Vector3.zero;
      rigidb.angularVelocity = 0;
      timestopped = 0;
       transform.position = startposition;
        
   }


    // Update is called once per frame
    void Update()
    {
      if (Stopped() && timestopped == max_frames && at_goal == false) {
           Reset();
        }
   }
}
