using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeData : MonoBehaviour
{
    // Start is called before the first frame update
    public int inSlot;
    private int days, health, waterStorage, foodStorage, hunger, thirst;

    void Start()
    {
        init(PlayerPrefs.GetInt("currentGame"));
    }

    public void init(int loadSlot)
    {
        inSlot = loadSlot;
        days = PlayerPrefs.GetInt("sl" + loadSlot + "d");
        health = 30;//PlayerPrefs.GetInt("sl" + loadSlot + "p");
        waterStorage = 3;//PlayerPrefs.GetInt("sl" + loadSlot + "a");
        foodStorage = PlayerPrefs.GetInt("sl" + loadSlot + "o");
        hunger = 10; //PlayerPrefs.GetInt("sl" + loadSlot + "u");
        thirst = 10; //PlayerPrefs.GetInt("sl" + loadSlot + "h");
    }

    public int getVal(string valueName)
    {
        if (valueName == "d")
        {
            return days;
        }
        else if (valueName == "p")
        {
            return health;
        }
        else if (valueName == "a")
        {
            return waterStorage;
        }
        else if (valueName == "o")
        {
            return foodStorage;
        }
        else if (valueName == "u")
        {
            return hunger;
        }
        else if (valueName == "h")
        {
            return thirst;
        }
        else
        {
            return 0;
        }
    }

    public void setVal(string valueName, int value)
    {
        if (valueName == "d")
        {
            days = value;
        }
        else if (valueName == "p")
        {
            Debug.Log(value);
            if (value > 100)
            {
                value = 100;
            }
            if (health + value < 0)
            {
                value = 0;
            }
            health = value;
        }
        else if (valueName == "a")
        {
            if (waterStorage + value < 0)
            {
                value = 0;
            }
            waterStorage = value;
        }
        else if (valueName == "o")
        {
            if (foodStorage + value < 0)
            {
                value = 0;
            }
            foodStorage = value;
        }
        else if (valueName == "u")
        {
            if (value > 100)
            {
                value = 100;
            }
            if (hunger + value < 0)
            {
                value = 0;
            }
            hunger = value;
        }
        else if (valueName == "h")
        {
            if (value > 100)
            {
                value = 100;
            }
            if (thirst + value < 0)
            {
                value = 0;
            }
            thirst = value;
        }
    }

    public void saveData()
    {
        PlayerPrefs.SetInt("sl" + inSlot + "d", days);
        PlayerPrefs.SetInt("sl" + inSlot + "p", health);
        PlayerPrefs.SetInt("sl" + inSlot + "a", waterStorage);
        PlayerPrefs.SetInt("sl" + inSlot + "o", foodStorage);
        PlayerPrefs.SetInt("sl" + inSlot + "u", hunger);
        PlayerPrefs.SetInt("sl" + inSlot + "h", thirst);
    }
}
