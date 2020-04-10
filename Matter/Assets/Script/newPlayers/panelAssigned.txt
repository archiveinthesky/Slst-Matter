using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelAssigned : MonoBehaviour
{
    public GameObject controller;
    public void completeInitAnim()
    {
        controller.GetComponent<objDescribe>().completeInit();
    }

    public void completeExitAnim()
    {
        controller.GetComponent<objDescribe>().completeExitPanel();
    }
}
