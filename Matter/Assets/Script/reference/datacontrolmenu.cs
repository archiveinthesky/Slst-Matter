using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class datacontrolmenu : MonoBehaviour
{

    private TouchScreenKeyboard keyboard;
    public GameObject sc1tile, sc1de, sc2title, sc2de, sc3title, sc3de;
    Text slot1txttitle, slot2txttitle, slot3txttitle, slot1txtde, slot2txtde, slot3txtde;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setslotvalues()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetString("pps1ttln", "徐徐和風");
        PlayerPrefs.SetInt("sl1d", 10);
        PlayerPrefs.SetInt("sl1h", 100);//*/
        slot1txttitle = sc1tile.GetComponent<Text>();
        slot2txttitle = sc2title.GetComponent<Text>();
        slot3txttitle = sc3title.GetComponent<Text>();
        slot1txtde = sc1de.GetComponent<Text>();
        slot2txtde = sc2de.GetComponent<Text>();
        slot3txtde = sc3de.GetComponent<Text>();
        slot1txttitle.text = "存檔一 " + PlayerPrefs.GetString("pps1ttln"); //playerprefsslot1titlename
        slot2txttitle.text = "存檔二 " + PlayerPrefs.GetString("pps2ttln");
        slot3txttitle.text = "存檔三 " + PlayerPrefs.GetString("pps3ttln");
        if (PlayerPrefs.GetString("pps1ttln") == ""){slot1txtde.text = "展開一場新的生存冒險!";}
        else{slot1txtde.text = "第" + PlayerPrefs.GetInt("sl1d") + "天 " + "生命值剩餘: " + PlayerPrefs.GetInt("sl1h");}
        if (PlayerPrefs.GetString("pps2ttln") == ""){slot2txtde.text = "展開一場新的生存冒險!";}
        else{slot1txtde.text = "第" + PlayerPrefs.GetInt("sl2d") + "天 " + "生命值剩餘: " + PlayerPrefs.GetInt("sl2h");}
        if (PlayerPrefs.GetString("pps3ttln") == ""){slot3txtde.text = "展開一場新的生存冒險!";}
        else{slot1txtde.text = "第" + PlayerPrefs.GetInt("sl3d") + "天 " + "生命值剩餘: " + PlayerPrefs.GetInt("sl3h");}
    }

    public void createnewgame(int saveslot)
    {
        Debug.Log("createnewgame " + saveslot);
        if (PlayerPrefs.GetString("pps" + saveslot + "ttln") != "")
        {
            //Launch Warning
        }
        else
        {
            inalitzenewgame(saveslot);
        }
        
    }

    public void continuegame(int saveslot)
    {
        Debug.Log("continuegame " + saveslot);
        PlayerPrefs.SetInt("currentrunningscene", saveslot);
    }

    void inalitzenewgame(int saveslot)
    {
            PlayerPrefs.SetString("pp3ttln", "a new name"); // needs user input sys
            PlayerPrefs.SetInt("sl" + saveslot + "h", 100);
            PlayerPrefs.SetInt("sl" + saveslot + "f", 100);
            PlayerPrefs.SetInt("sl" + saveslot + "w", 100);
            PlayerPrefs.SetInt("sl" + saveslot + "d", 0);
            PlayerPrefs.SetInt("currentrunningscene", saveslot);
            //switch to new scene
    }


    
}
