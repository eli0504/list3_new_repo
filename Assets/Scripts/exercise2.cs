using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour
{
    private void Start()
    {
        int number = 9; //number
        bool result = isEven(number); //function call
        Debug.Log(result);
    }


    public bool isEven (int number) //function that determines if it is even or not.
    {
        if (number % 2 == 0)
        {
            Debug.Log("The number is even"); 
            return true; //returns true if the number "9" is even
        }
        else
        {
            Debug.Log("The number is not even");
            return false; //returns false if the number "9" is not even
        }
    }
}
