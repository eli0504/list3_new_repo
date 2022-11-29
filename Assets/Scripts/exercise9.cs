using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise9 : MonoBehaviour
{
    int b = 20; //base
    int height = 10; //height

    private void Start()
    {
        TriangleArea(b, height);  //function result
    }

    public void TriangleArea(int b, int height) //function that determines the area of a triangle
    {
        int area = b * height / 2;  //formula to calculate the area of the triangle
        if (area > 0)
        {
            Debug.Log($"The area of the triangle is {area}");
        }
        else
        {
            Debug.Log("The area cannot be calculated.");  //in case it could not be calculated
        }
    }
}
