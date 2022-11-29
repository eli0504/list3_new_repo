using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise8 : MonoBehaviour
{
    private void Start()
    {
        int number = 2003; //year
        bool result = isLeapYear(number); //function call
        Debug.Log(result);
    }
    
    public bool isLeapYear (int number)
    {
        if (number % 4 == 0 && number % 100 == 0)   //calculate if 2003 is a leap year o not
        {
            Debug.Log("It is a leap year");
            return true;
        }
        else if (number % 100 == 0 && number % 400 == 0)
        {
            Debug.Log("It is a leap year");
            return true;
        }
        else
        {
            Debug.Log("Not a leap year");
            return false;                                                       
        }
    }
}
