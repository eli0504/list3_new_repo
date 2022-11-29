using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour
{
    int x = 20; //dividend
    int y = 10; //divisor


    private void Start()
    {
        division(x, y); //function call
    }



    public void division(int x, int y) //function that determines if the division is exact
    {
        if (x % y == 0)  //calculate if the remainder is exact or not
        {
            Debug.Log("The division is exact");
        }
        else
        {
            Debug.Log("The division is not exact");
        }

    }
}
