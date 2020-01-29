using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class datacontrol : MonoBehaviour
{

    public GameObject sl1ti, sl1de, sl2ti, sl2de, sl3ti, sl3de;  //SLot1Title, SLot1DEscription
    Text s1titxt, s1detxt, s2titxt, s2detxt, s3titxt, s3detxt;   //Slot1TItleTeXT

    public void setslotvals()
    {
        s1titxt = sl1ti.GetComponent<Text>();
        s2titxt = sl2ti.GetComponent<Text>();
        s3titxt = sl3ti.GetComponent<Text>();
        s1detxt = sl1de.GetComponent<Text>();
        s2detxt = sl2de.GetComponent<Text>();
        s3detxt = sl3de.GetComponent<Text>();

        s1titxt.text = "存檔一 " + PlayerPrefs.GetString("pps1ttln"); //playerprefsslot1titlename
        s2titxt.text = "存檔二 " + PlayerPrefs.GetString("pps2ttln");
        s3titxt.text = "存檔三 " + PlayerPrefs.GetString("pps3ttln");
        if (PlayerPrefs.GetString("pps1ttln") == ""){s1detxt.text = "展開一場新的生存冒險!";}
        else{s1detxt.text = "第" + PlayerPrefs.GetInt("sl1d") + "天 " + "生命值剩餘: " + PlayerPrefs.GetInt("sl1h");}
        if (PlayerPrefs.GetString("pps2ttln") == ""){s2detxt.text = "展開一場新的生存冒險!";}
        else{s2detxt.text = "第" + PlayerPrefs.GetInt("sl2d") + "天 " + "生命值剩餘: " + PlayerPrefs.GetInt("sl2h");}
        if (PlayerPrefs.GetString("pps3ttln") == ""){s3detxt.text = "展開一場新的生存冒險!";}
        else{s3detxt.text = "第" + PlayerPrefs.GetInt("sl3d") + "天 " + "生命值剩餘: " + PlayerPrefs.GetInt("sl3h");}
    }
}
