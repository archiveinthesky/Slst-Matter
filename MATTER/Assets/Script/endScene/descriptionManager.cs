using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class descriptionManager : MonoBehaviour
{
    public List<string> endingNames;
    public List<string> endingDescriptions;
    public GameObject fadecloth, completeEnding, description;
    void Start()
    {
        fadecloth.SetActive(true);
        endingNames.Add("死亡");
        endingDescriptions.Add("你的生命值歸零了\n請重新開始遊戲吧");

        endingNames.Add("");
        endingDescriptions.Add("");

        endingNames.Add("");
        endingDescriptions.Add("");

        endingNames.Add("");
        endingDescriptions.Add("");

        endingNames.Add("");
        endingDescriptions.Add("");

        fadecloth.GetComponent<Animator>().Play("fadecloth-fade-in");

        setTexts(PlayerPrefs.GetInt("endgameId"));
    }

    void setTexts(int id)
    {
        completeEnding.GetComponent<Text>().text += endingNames[id];
        description.GetComponent<Text>().text = endingDescriptions[id];
    }

    public void returnToMainScreen()
    {
        int saveslot = PlayerPrefs.GetInt("currentGame");
        PlayerPrefs.DeleteKey("pps" + saveslot + "ttln");
        PlayerPrefs.DeleteKey("sl" + saveslot + "d");
        PlayerPrefs.DeleteKey("sl" + saveslot + "p");
        PlayerPrefs.DeleteKey("sl" + saveslot + "a");
        PlayerPrefs.DeleteKey("sl" + saveslot + "o");
        PlayerPrefs.DeleteKey("sl" + saveslot + "u");
        PlayerPrefs.DeleteKey("sl" + saveslot + "h");
        for (int i = 0; i < PlayerPrefs.GetInt("sl" + saveslot + "ev"); i++)
        {
            PlayerPrefs.DeleteKey("sl" + saveslot + "ev_l_" + i);
        }
        PlayerPrefs.DeleteKey("sl" + PlayerPrefs.GetInt("sl" + saveslot + "ev") + "ev");
        PlayerPrefs.DeleteKey("sl" + saveslot + "ev_c");
        PlayerPrefs.DeleteKey(saveslot + "_waitingEvent");
        PlayerPrefs.DeleteKey("CntEveSys_triggerDay");
        PlayerPrefs.DeleteKey("CntEveSys_line");
        fadecloth.SetActive(true);
        fadecloth.GetComponent<Animator>().Play("fadecloth-fade-out");

        
    }


}
