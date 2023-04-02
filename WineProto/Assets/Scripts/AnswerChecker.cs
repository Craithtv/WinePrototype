using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WineSim.Items;

public class AnswerChecker : MonoBehaviour
{
    public Wine wine1, wine2;



    // Start is called before the first frame update
    void Start()
    {
        if(wine1.varietal == wine2.varietal)
        {
            Debug.Log("Varietal match");
        }
        else
        {
            Debug.Log("Varietal does not match");
        }

        if(wine1.origin == wine2.origin)
        {
            Debug.Log("Origin match!");
        }
        else
        {Debug.Log("Origin does not match");
        }
        if(wine1.color == wine2.color)
        {
            Debug.Log("Color match");
        }
        else
        {
            Debug.Log("Color does not match");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
