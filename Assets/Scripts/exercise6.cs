using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise6 : MonoBehaviour
{
   private void Start()
    {
        int x = 9; //real number
        int y = 20; //real number

        int result = number(x, y); //function call
        Debug.Log(result);
    }
    
    
     public int number(int x, int y)  //function that determines which number is larger
    {
        if(y > x)  //calculate the larger number
        {
            Debug.Log(y);
            return y;
        }
        else
        {
            Debug.Log(x);
            return x;
        }
    }
}
