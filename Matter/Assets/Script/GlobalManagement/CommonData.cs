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
        if (health > 100){health = 100;}
        else if (health < 0) { health = 0; }
        if (hunger > 100) { hunger = 100; }
        else if (hunger < 0) { hunger = 0; }
        if (thirst > 100) { thirst = 100; }
        else if (thirst < 0) { thirst = 0; }
    }
}
