using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class playershot : MonoBehaviour
{
   [SerializeField] Rigidbody2D rigidb;
   [SerializeField] LineRenderer line;
   [SerializeField] float maxvelocity = 10f; 
   [SerializeField] float velocity = 1f;
   [SerializeField] Vector2 startposition;
   bool dragging; 

   void Drag() {
      if (rigidb.velocity.magnitude >= 0.5f) {
         dragging = false;
      }else {
      dragging = true;
      }
    }
   void Dragmove() {

   }
   void Release(Vector2 endposition) {
      dragging = false; 
      //distance from ball to end of mouse input
      float dist = Vector2.Distance(transform.position, endposition);

      Vector2 direction = (Vector2)transform.position - endposition;
      rigidb.velocity = Vector2.ClampMagnitude(direction * velocity, maxvelocity);
   } 

   //check if ball is stopped
   bool Stopped() {
      if (rigidb.velocity.magnitude == 0f){
         return true;
      } else {
         return false;
      }
   }   

      //handles player input
      void input (){
         //get mouse postion on input 
         Vector2 inputpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         //distance of line drawn from position of ball and mouse input
         float distance = Vector2.Distance(transform.position, inputpos);
         //drag has to start close to the ball 
         if(Input.GetMouseButtonDown(0) && distance <= 0.5f) Drag();
         if(Input.GetMouseButtonDown(0) && dragging) Dragmove();
         if(Input.GetMouseButtonUp(0) && dragging) Release(inputpos);

         
         
      }

    // Start is called before the first frame update
   void Start()
    {
      
    }

    // Update is called once per frame
   void Update()
    {
        input();
        
    }
}
