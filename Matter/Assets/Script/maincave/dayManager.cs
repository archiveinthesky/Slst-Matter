using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dayManager : MonoBehaviour
{
    public GameObject fadeCloth;
    public GameObject dayShower;
    public bool inAnimation;
    private int dayCounter;

    void Start()
    {
        dayCounter = GetComponent<lifeData>().getVal("d") - 1;
        newDay();

    }
    public void dayEnd()
    {
        inAnimation = true;
        fadeCloth.GetComponent<Transform>().position = new Vector3(Camera.main.transform.position.x, fadeCloth.GetComponent<Transform>().position.y, fadeCloth.GetComponent<Transform>().position.z);
        fadeCloth.SetActive(true);
        dayShower.SetActive(false);
        GetComponent<PlayerInfoManager>().dayEnd();
        fadeCloth.GetComponent<Animator>().Play("nextday");
    }
    public void newDay()
    {
        inAnimation = true;
        if (dayCounter == 31 || GetComponent<lifeData>().getVal("p") <= 0 || PlayerPrefs.GetInt("endgameId") != -1)
        {
            SceneManager.LoadScene("endScene");
        }
        else
        {
            fadeCloth.SetActive(true);
            dayShower.SetActive(true);
            dayCounter++;
            GetComponent<lifeData>().setVal("d", dayCounter);
            GetComponent<lifeData>().saveData();
            dayShower.GetComponent<Text>().text = "第" + dayCounter + "天";
            GetComponent<SolveContSystem>().newday(dayCounter);
            GetComponent<EventSystem>().newDay();
            GetComponent<PlayerInfoManager>().newday();
            fadeCloth.GetComponent<Animator>().Play("showday");
        }
    }

    public void newDayEnd()
    {
        fadeCloth.SetActive(false);
        inAnimation = false;
    }






}
