using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recievedata : MonoBehaviour
{
    string todayEvent, yesterdaysEvent, yesterdaysChange;

    public void newDay()
    {
        //dajun code of get event
        applyEffect(yesterdaysChange);
    }

    public string getTodayEvent()
    {
        return todayEvent;
    }

    public string getYestChange()
    {
        return yesterdaysEvent;
    }

    void applyEffect(string changes)
    {
        for (int i = 0; i < changes.Length; i++)
        {
            string edititem = changes[i].ToString();
            i++;
            int times;
            if (changes[i].ToString() == "+"){
                times = 1;
            }else{
                times = -1;
            }
            i++;
            int editval = 0;
            while (changes[i].ToString() != ","){
                editval *= 10;
                editval += int.Parse(changes[i].ToString());
                i++;
            }
            GetComponent<lifeData>().setVal(edititem, GetComponent<lifeData>().getVal(edititem) + editval * times);
        }
    }

}
