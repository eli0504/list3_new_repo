using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise7 : MonoBehaviour
{
    private void Start()
    {
        int realNumber = -10;
        int result = absoluteNumber(realNumber); //function call
        Debug.Log(result);
    }


    public int absoluteNumber (int realNumber) //function determines the absolute value of the real number
    {
        if(realNumber < 0) 
        {
            return (-1) * realNumber; //calculate the absolute value of -10
        }
        else
        {
            return realNumber;
        }
    }

}
