using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoManager : MonoBehaviour
{
    public GameObject controller;
    public GameObject enterUIInfoBtn;
    public GameObject UIInfo;
    public GameObject modePlayerInfoBtn, modeHasObjectsBtn, modeTodayEventBtn, modeEventHistoryBtn;
    public GameObject PanelTitle, PanelSub;
    public GameObject playerInfoMother, playerHasObjects, playerTodayEvent, playerEventHistory;
    public GameObject IGDT, IGPT, IGHT, IGWT; // panel player info "InGame_Tet"
    public GameObject IGDS, IGPS, IGHS, IGWS;
    public GameObject HOLPT, HORPT;
    public GameObject TETXT;
    public GameObject ERTXT, ERRES;
    private string todayevent, yesterdayDescription, yesterdayeffect;
    private bool eventdone, eventDecision;

    void Start()
    {
        UIInfo.SetActive(false);
    }

    void Update()
    {
        enterUIInfoBtn.GetComponent<Transform>().position = new Vector3(Camera.main.GetComponent<Transform>().position.x - 930, enterUIInfoBtn.GetComponent<Transform>().position.y, enterUIInfoBtn.GetComponent<Transform>().position.z);
        UIInfo.GetComponent<Transform>().position = new Vector3(Camera.main.GetComponent<Transform>().position.x, UIInfo.GetComponent<Transform>().position.y, UIInfo.GetComponent<Transform>().position.z);
    }

    public void newday()
    {
        List<string> retrieveEvent = GetComponent<EventSystem>().getEvents();
        eventdone = false;
        yesterdayDescription = retrieveEvent[0];
        yesterdayeffect = retrieveEvent[1];
        todayevent = retrieveEvent[2];
        applyEffect(yesterdayeffect);
    }

    public void enableUIInfo()
    {
        UIInfo.SetActive(true);
        UIInfo.GetComponent<Animator>().Play("uiinfo-zoom-in");
        enterPlayerInfo();
    }

    public void exitUIInfo()
    {
        UIInfo.GetComponent<Animator>().Play("uiinfo-zoom-out");
    }

    public void doneExitUIInfo()
    {
        UIInfo.SetActive(false);
        if (eventdone)
        {
            controller.GetComponent<dayManager>().dayEnd();
        }
    }

    public void eventDecided()
    {
        eventdone = true;
    }

    public void enterPlayerInfo()
    {
        modePlayerInfoBtn.GetComponent<Text>().color = new Vector4(0, 255, 200, 255);
        modeHasObjectsBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeTodayEventBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeEventHistoryBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        PanelTitle.GetComponent<Text>().text = "玩家資訊";
        PanelSub.GetComponent<Text>().text = "目前遊戲: " + PlayerPrefs.GetString("pps" + controller.GetComponent<lifeData>().inSlot + "ttln");
        IGDT.GetComponent<Text>().text = "遊戲內天數: " + controller.GetComponent<lifeData>().getVal("d");
        IGPT.GetComponent<Text>().text = "生命值: " + controller.GetComponent<lifeData>().getVal("p");
        IGHT.GetComponent<Text>().text = "飽食度: " + controller.GetComponent<lifeData>().getVal("u");
        IGWT.GetComponent<Text>().text = "水分: " + controller.GetComponent<lifeData>().getVal("h");
        IGDS.GetComponent<Slider>().value = controller.GetComponent<lifeData>().getVal("d");
        IGPS.GetComponent<Slider>().value = controller.GetComponent<lifeData>().getVal("p");
        IGHS.GetComponent<Slider>().value = controller.GetComponent<lifeData>().getVal("u");
        IGWS.GetComponent<Slider>().value = controller.GetComponent<lifeData>().getVal("h");
        playerInfoMother.SetActive(true);
        playerHasObjects.SetActive(false);
        playerTodayEvent.SetActive(false);
        playerEventHistory.SetActive(false);
    }

    public void enterHasObjects()
    {
        //create show text
        modePlayerInfoBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeHasObjectsBtn.GetComponent<Text>().color = new Vector4(0, 255, 200, 255);
        modeTodayEventBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeEventHistoryBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);

        string showValsLeft = "", showValsRight = "";
        showValsLeft = showValsLeft + "護身符: " + controller.GetComponent<objectManager>().returnObjsVal(1).ToString() + "\n";
        showValsLeft = showValsLeft + "斧頭: " + controller.GetComponent<objectManager>().returnObjsVal(2) + "\n";
        showValsLeft = showValsLeft + "醫藥書: " + controller.GetComponent<objectManager>().returnObjsVal(3) + "\n";
        showValsLeft = showValsLeft + "能量飲料: " + controller.GetComponent<objectManager>().returnObjsVal(5) + "\n";
        showValsLeft = showValsLeft + "急救箱: " + controller.GetComponent<objectManager>().returnObjsVal(6) + "\n";
        showValsLeft = showValsLeft + "手電筒: " + controller.GetComponent<objectManager>().returnObjsVal(7) + "\n";
        showValsLeft = showValsLeft + "食物: " + controller.GetComponent<objectManager>().returnObjsVal(8) + "\n";
        showValsLeft = showValsLeft + "腎上腺素: " + controller.GetComponent<objectManager>().returnObjsVal(9);

        showValsRight += "香菇: " + controller.GetComponent<objectManager>().returnObjsVal(10) + "\n";
        showValsRight += "步槍: " + controller.GetComponent<objectManager>().returnObjsVal(11) + "\n";
        showValsRight += "返魂香: " + controller.GetComponent<objectManager>().returnObjsVal(12) + "\n";
        showValsRight += "水: " + controller.GetComponent<objectManager>().returnObjsVal(14);

        HOLPT.GetComponent<Text>().text = showValsLeft;
        HORPT.GetComponent<Text>().text = showValsRight;
        playerInfoMother.SetActive(false);
        playerHasObjects.SetActive(true);
        playerTodayEvent.SetActive(false);
        playerEventHistory.SetActive(false);
    }

    public void enterTodayEvent()
    {
        modePlayerInfoBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeHasObjectsBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeTodayEventBtn.GetComponent<Text>().color = new Vector4(0, 255, 200, 255);
        modeEventHistoryBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);

        TETXT.GetComponent<Text>().text = todayevent;

        playerInfoMother.SetActive(false);
        playerHasObjects.SetActive(false);
        playerTodayEvent.SetActive(true);
        playerEventHistory.SetActive(false);
    }

    public void eventConfirm()
    {
        eventDecision = true;
    }

    public void eventDecline()
    {
        eventDecision = false;
    }

    public void enterEventResult()
    {
        modePlayerInfoBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeHasObjectsBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeTodayEventBtn.GetComponent<Text>().color = new Vector4(255, 255, 255, 255);
        modeEventHistoryBtn.GetComponent<Text>().color = new Vector4(0, 255, 200, 255);

        ERTXT.GetComponent<Text>().text = yesterdayDescription;
        string compileres = "";
        string fromres = yesterdayeffect;
        Debug.Log(fromres.Length);
        for (int i = 0; i < fromres.Length; i++)
        {
            if (fromres[i].ToString() == "p")
            {
                compileres += "生命值";
            }
            else if (fromres[i].ToString() == "o")
            {
                compileres += "食物";
            }
            else if (fromres[i].ToString() == "a")
            {
                compileres += "水";
            }
            else if (fromres[i].ToString() == "u")
            {
                compileres += "飽食度";
            }
            else if (fromres[i].ToString() == "h")
            {
                compileres += "水分";
            }
            i++;
            Debug.Log(fromres[i].ToString());
            compileres += fromres[i].ToString();
            i++;
            while (fromres[i] != ',')
            {
                Debug.Log(compileres);
                Debug.Log(fromres[i].ToString());
                compileres += fromres[i].ToString();
                i++;
            }
            compileres += "\n";
        }
        ERRES.GetComponent<Text>().text = compileres;


        playerInfoMother.SetActive(false);
        playerHasObjects.SetActive(false);
        playerTodayEvent.SetActive(false);
        playerEventHistory.SetActive(true);
    }

    void applyEffect(string changes)
    {
        for (int i = 0; i < changes.Length; i++)
        {
            string edititem = changes[i].ToString();
            i++;
            int times;
            if (changes[i].ToString() == "+")
            {
                times = 1;
            }
            else
            {
                times = -1;
            }
            i++;
            int editval = 0;
            while (changes[i].ToString() != ",")
            {
                editval *= 10;
                Debug.Log(changes[i].ToString());
                editval += int.Parse(changes[i].ToString());
                i++;
            }
            GetComponent<lifeData>().setVal(edititem, GetComponent<lifeData>().getVal(edititem) + editval * times);
        }
    }

    public void dayEnd()
    {
        GetComponent<EventSystem>().setEventDecision(eventDecision);
    }

}
