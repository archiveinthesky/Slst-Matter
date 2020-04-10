using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagement : MonoBehaviour
{
    public int hrs, min, day;
    public CommonData gd;
    int saveslot;
    void Start()
    {
        saveslot = gd.saveslot;
        loaddata();
        StartCoroutine(counttime());
    }

    void Update()
    {

    }

    void newday()
    {
        StopCoroutine(counttime());
        if (gd.incave)
        {

        }
    }

    IEnumerator counttime()
    {
        yield return new WaitForSeconds(40);
        if (min == 30)
        {
            hrs++;
            min = 0;
        }
        else
        {
            min += 30;
        }
        if (hrs >= 22)
        {
            newday();
        }
        savedata();
    }

    void loaddata()
    {
        hrs = PlayerPrefs.GetInt("tim" + saveslot + "_hrs");
        min = PlayerPrefs.GetInt("tim" + saveslot + "_min");
        day = PlayerPrefs.GetInt("tim" + saveslot + "_day");
    }

    void savedata()
    {
        PlayerPrefs.SetInt("tim_hrs", hrs);
        PlayerPrefs.SetInt("tim_min", min);
        PlayerPrefs.SetInt("tim_day", day);
    }
}
