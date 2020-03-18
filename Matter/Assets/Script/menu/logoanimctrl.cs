using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logoanimctrl : MonoBehaviour
{

    public GameObject controller;
    // Start is called before the first frame update
    public void continueon()
    {
        controller.GetComponent<menuController>().canvasin();
        gameObject.SetActive(false);
    }
}
