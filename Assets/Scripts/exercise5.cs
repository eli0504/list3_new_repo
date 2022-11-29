using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise5 : MonoBehaviour
{
    int x = 10;  //number

    private void Start()
    {
        multiplication(x); //function call
    }

    public void multiplication(int x)  //multiplication table of 10
    {
        Debug.Log($"{x} * 1 = 10");
        Debug.Log($"{x} * 2 = 20");
        Debug.Log($"{x} * 3 = 30");
        Debug.Log($"{x} * 4 = 40");
        Debug.Log($"{x} * 5 = 50");
        Debug.Log($"{x} * 6 = 60");
        Debug.Log($"{x} * 7 = 70");
        Debug.Log($"{x} * 8 = 80");
        Debug.Log($"{x} * 9 = 90");
        Debug.Log($"{x} * 10 = 100");

    }
}
