using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershot : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rigidb;
   //will add line visual for direction 
   //[SerializeField] private LineRenderer line;
   [SerializeField] private float maxvelocity = 15f; 
   [SerializeField] private float velocity = 1.5f;
   private bool dragging; 

   //conditional for when player can input again. 
   void Drag() {
      if (rigidb.velocity.magnitude > 0f) { dragging = false; }
      else { dragging = true; }
    }

   void Release(Vector2 endposition) {
      dragging = false; 
      //check if distance from ball to end of mouse input is too short
      float dist = Vector2.Distance(transform.position, endposition); 
      if (dist < 0.5f) { return; }
      
      Vector2 direction = (Vector2)transform.position - endposition;
      //makes sure velocity isn't too much to send ball flying out of bounds
      rigidb.velocity = Vector2.ClampMagnitude(direction * velocity, maxvelocity);
   }   

      //handles player input
      void input (){
         //get mouse postion on input 
         Vector2 inputpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         //distance of line drawn from position of ball and mouse input
         float distance = Vector2.Distance(transform.position, inputpos);
         //drag has to start close to the ball 
         if(Input.GetMouseButtonDown(0) && distance <= 0.5f) Drag();
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
