using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeScreenAssigned : MonoBehaviour
{
    public GameObject controller;

    public void nextDayAnimDone()
    {
        controller.GetComponent<dayManager>().newDay();
    }

    public void newDayAnimDone()
    {
        controller.GetComponent<dayManager>().newDayEnd();
    }
}
