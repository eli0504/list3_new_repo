using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour
{
   private void Start()
    {
        string character = "e"; //letter
        bool result = letter(character); //function call
        Debug.Log(result);  
}
    
    
    public bool letter(string character) //function that determines if it is a vowel or not
    {
        if (character == "a" || character == "e" || character == "i" || character == "o" || character == "u")
        {
            Debug.Log("The letter is a vowel");  //returns true if the character "e" matches the previous characters 
            return true;

        }
        else
        {
            Debug.Log("The letter is a consonant");
            return false;  //returns false if the character "e" does not correspond to the previous characters
        }

    }
}
 