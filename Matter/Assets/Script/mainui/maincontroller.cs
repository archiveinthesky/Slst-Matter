using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincontroller : MonoBehaviour
{
    int healthi, hungeri, wateri, daysi, saveslot;
    // Start is called before the first frame update
    void Start()
    {   
        loadslot();
        
    }
    // Update is called once per 8frame
    void Update()
    {
        
    }

    void loadslot()
    {
        saveslot = PlayerPrefs.GetInt("currentrunningscene");
        healthi = PlayerPrefs.GetInt("sl" + saveslot + "h");
        hungeri = PlayerPrefs.GetInt("sl" + saveslot + "f");
        wateri = PlayerPrefs.GetInt("sl" + saveslot + "w");
        daysi = PlayerPrefs.GetInt("sl" + saveslot + "d");
    }

    
}
