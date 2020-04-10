using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommonData : MonoBehaviour
{
    public int saveslot;
    public int health, hunger, thirst;
    public bool incave;


    void Start()
    {
        saveslot = PlayerPrefs.GetInt("saveslot");
        Scene inScene = SceneManager.GetActiveScene();
        incave = inScene.name == "maincave" ? incave = true : incave = false;
    }

    void Update()
    {
        if (health > 100)
        {
            
        }
    }
}
