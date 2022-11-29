using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise4 : MonoBehaviour
{
   private void Start()
    {
        Movement(Vector3.forward); //function call
    }

   public void Movement (Vector3 direction) 
    {
        transform.Translate(direction);  //change the initial position (0,0,0) for the new one (0,0,1)
    }
}
