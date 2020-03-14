using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoManager : MonoBehaviour
{
    public GameObject controller;
    public GameObject UIInfo;
    public GameObject modePlayerInfoBtn, modeHasObjectsBtn, modeTodayEventBtn, modeEventHistoryBtn;
    public GameObject PanelTitle, PanelSub;
    public GameObject playerInfoMother;
    public GameObject IGDT, IGPT, IGHT, IGWT; // panel player info "InGame_Tet"
    public GameObject IGDS, IGPS, IGHS, IGWS;

    public void enableUIInfo()
    {
        UIInfo.SetActive(true);
        enterPlayerInfo();
    }

    public void enterPlayerInfo()
    {
        modePlayerInfoBtn.GetComponent<Text>().color = new Vector4(0, 255, 200, 255);
        PanelTitle.GetComponent<Text>().text = "玩家資訊";
        PanelSub.GetComponent<Text>().text = "目前遊戲: " + PlayerPrefs.GetString("pps" + controller.GetComponent<lifeData>().inSlot + "ttln");
        IGDT.GetComponent<Text>().text = IGDT.GetComponent<Text>().text + controller.GetComponent<lifeData>().getVal("d");
        IGPT.GetComponent<Text>().text = IGPT.GetComponent<Text>().text + controller.GetComponent<lifeData>().getVal("p");
        IGHT.GetComponent<Text>().text = IGHT.GetComponent<Text>().text + controller.GetComponent<lifeData>().getVal("u");
        IGWT.GetComponent<Text>().text = IGWT.GetComponent<Text>().text + controller.GetComponent<lifeData>().getVal("h");
        IGDS.GetComponent<Slider>().value = controller.GetComponent<lifeData>().getVal("d");
        IGPS.GetComponent<Slider>().value = controller.GetComponent<lifeData>().getVal("p");
        IGHS.GetComponent<Slider>().value = controller.GetComponent<lifeData>().getVal("u");
        IGWS.GetComponent<Slider>().value = controller.GetComponent<lifeData>().getVal("h");
        playerInfoMother.SetActive(true);
    }

    public void enterHasObjects()
    {
        //create show text
        string showVals = "";

    }


    void Start()
    {
        enableUIInfo();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
