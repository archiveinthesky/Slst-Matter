using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayManager : MonoBehaviour
{
    public GameObject fadeCloth;
    private int dayCounter;

    void Awake()
    {
        dayCounter = 0;
        newDay();

    }
    public void dayEnd()
    {
        fadeCloth.SetActive(true);
        fadeCloth.GetComponent<Animator>().Play("nextday");
    }
    public void newDay() 
    {
        fadeCloth.SetActive(true);
        GetComponent<lifeData>().saveData();
        dayCounter++;
        GetComponent<lifeData>().setVal("d", dayCounter);
        GetComponent<recievedata>().newDay();
        fadeCloth.GetComponent<Animator>().Play("showday");
    }

    public void newDayEnd()
    {
        fadeCloth.SetActive(false);
    }


    
}
