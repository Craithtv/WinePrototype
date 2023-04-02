using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WineSim.Items;

public class AnswerChecker : MonoBehaviour
{
    public Wine wine1, wine2;
    public ScriptableObject [] PossibleWines;
    public ScriptableObject cabSauvObj; 
    public ScriptableObject falanObj;
    public ScriptableObject neroObj;
    
    

    // Start is called before the first frame update
    void Start()
    {
        GetAnswerWine();
    }

    private void GetAnswerWine()
    {
        wine2 = PossibleWines[Random.Range(0, PossibleWines.Length)] as Wine;
    }

    private void CheckAnswer()
    {
        if (wine1.varietal == wine2.varietal)
        {
            Debug.Log("Varietal match");
        }
        else
        {
            Debug.Log("Varietal does not match");
        }

        if (wine1.origin == wine2.origin)
        {
            Debug.Log("Origin match!");
        }
        else
        {
            Debug.Log("Origin does not match");
        }
        if (wine1.color == wine2.color)
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

    public void OnCabButton()
    {
        wine1 = cabSauvObj as Wine;
        CheckAnswer();
    }
    public void OnFalButton()
    {
        wine1 = falanObj as Wine;
        CheckAnswer();
    }
    public void OnNeroButton()
    {
        wine1 = neroObj as Wine;
        CheckAnswer();
    }
}
