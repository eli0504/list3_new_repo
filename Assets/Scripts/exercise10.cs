using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise10 : MonoBehaviour
{
    private void Start()
    {
        transform.localScale += Vector3.one;  //function call
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //every time you click it increases the scale by one unit on all axes.
        {
            transform.localScale += Vector3.one;  
        }  
    }
}
