using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dayManager : MonoBehaviour
{
    public GameObject fadeCloth;
    public GameObject dayShower;
    private int dayCounter;

    void Awake()
    {
        dayCounter = 0;
        newDay();

    }
    public void dayEnd()
    {
        fadeCloth.SetActive(true);
        dayShower.SetActive(false);
        fadeCloth.GetComponent<Animator>().Play("nextday");
    }
    public void newDay()
    {
        if (dayCounter == 31)
        {
            SceneManager.LoadScene("endScene");
        }
        else
        {
            fadeCloth.SetActive(true);
            dayShower.SetActive(true);
            GetComponent<lifeData>().saveData();
            dayCounter++;
            dayShower.GetComponent<Text>().text = "第" + dayCounter + "天";
            GetComponent<lifeData>().setVal("d", dayCounter);
            GetComponent<recievedata>().newDay();
            GetComponent<PlayerInfoManager>().newday();
            fadeCloth.GetComponent<Animator>().Play("showday");
        }
    }

    public void newDayEnd()
    {
        fadeCloth.SetActive(false);
    }




}
