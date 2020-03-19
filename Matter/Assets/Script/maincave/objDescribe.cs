using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objDescribe : MonoBehaviour
{
    public GameObject objectPanel, PanelImage, PanelTitle, PanelText, PanelApply;
    public Sprite[] objectsTexture;
    public List<string> objectTitle;
    public List<string> objectDescribe;
    public List<string> objectApply;
    public bool inPanel;
    private int mostRecentID;

    void Start()
    {
        objectTitle.Add("護身符");
        objectTitle.Add("斧頭");
        objectTitle.Add("醫藥書");
        objectTitle.Add("儲物櫃");
        objectTitle.Add("能量飲料");
        objectTitle.Add("急救箱"); //sp6
        objectTitle.Add("手電筒");
        objectTitle.Add("食物"); //sp8
        objectTitle.Add("腎上腺素");
        objectTitle.Add("香菇");
        objectTitle.Add("步槍");
        objectTitle.Add("返魂香");
        objectTitle.Add("相片");
        objectTitle.Add("水"); //14

        objectDescribe.Add("祖傳的護身符\n聽家人說能除邪添運\n這次準備來研發解藥時就戴上了");
        objectDescribe.Add("一把破舊的斧頭\n之前在基地中的緊急工具中發現的");
        objectDescribe.Add("為了研發解藥時能有個參考\n所以便戴上了");
        objectDescribe.Add("放東西用的置物櫃");
        objectDescribe.Add("託公司送來的飲料\n咖啡沒了後，我就一直靠著能量飲料維生");
        objectDescribe.Add("一些基本的急救用絣 \n可使用以補回50%生命值");
        objectDescribe.Add("緊急用的手電筒");
        objectDescribe.Add("公司送來的食物\n可食用以補回30%飢餓值");
        objectDescribe.Add("因為身體的老毛病\n所以偶爾得注射腎上腺素");
        objectDescribe.Add("或許有毒的香菇");
        objectDescribe.Add("因為在森林中\n公司怕我有危險\n所以配發的");
        objectDescribe.Add("一朵奇特的花朵");
        objectDescribe.Add("之前在某個地方拍的\n可是卻想不起來在哪裡");
        objectDescribe.Add("公司送來的水\n可飲用以補回30%水分");

        objectApply.Add("");
        objectApply.Add("");
        objectApply.Add("");
        objectApply.Add("");
        objectApply.Add("");
        objectApply.Add("使用急救包");
        objectApply.Add("");
        objectApply.Add("食用一罐食物");
        objectApply.Add("");
        objectApply.Add("");
        objectApply.Add("");
        objectApply.Add("");
        objectApply.Add("");
        objectApply.Add("喝一灌水");


    }

    public void init(int id)
    {
        if (!inPanel)
        {
            objectPanel.GetComponent<Transform>().position = new Vector3(Camera.main.GetComponent<Transform>().position.x, objectPanel.GetComponent<Transform>().position.y, objectPanel.GetComponent<Transform>().position.z);
            objectPanel.SetActive(true);
            PanelImage.GetComponent<Image>().sprite = objectsTexture[id];
            PanelTitle.GetComponent<Text>().text = objectTitle[id];
            PanelText.GetComponent<Text>().text = objectDescribe[id];
            if (objectApply[id] != "")
            {
                PanelApply.SetActive(true);
                PanelApply.GetComponent<Text>().text = objectApply[id];
            }
            else
            {
                PanelApply.SetActive(false);
            }
            mostRecentID = id;
            objectPanel.GetComponent<Animator>().Play("panel-zoom-in");
        }
    }

    public void objApplyValue()
    {
        if (mostRecentID == 5)
        {
            GetComponent<lifeData>().setVal("p", GetComponent<lifeData>().getVal("p") + 50);
            GetComponent<objectManager>().caveObjects[5] -= 1;

        }
        else if (mostRecentID == 7)
        {
            GetComponent<lifeData>().setVal("u", GetComponent<lifeData>().getVal("u") + 30);
            GetComponent<lifeData>().setVal("o", GetComponent<lifeData>().getVal("o") - 1);
        }
        else if (mostRecentID == 13)
        {
            GetComponent<lifeData>().setVal("h", GetComponent<lifeData>().getVal("h") + 30);
            Debug.Log(GetComponent<lifeData>().getVal("a"));
            GetComponent<lifeData>().setVal("a", GetComponent<lifeData>().getVal("a") - 1);
            Debug.Log(GetComponent<lifeData>().getVal("a"));
        }
        exitPanel();
    }

    public void completeInit()
    {
        inPanel = true;
    }

    public void exitPanel()
    {
        if (inPanel)
        {
            objectPanel.GetComponent<Animator>().Play("panel-zoom-out");
        }
    }

    public void completeExitPanel()
    {
        inPanel = false;
        objectPanel.SetActive(false);
    }
}
