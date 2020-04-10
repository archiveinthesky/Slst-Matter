using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiinfoAssigned : MonoBehaviour
{
    public GameObject controller;

    public void donePlayerInfo()
    {
        controller.GetComponent<PlayerInfoManager>().doneExitUIInfo();
    }

}
