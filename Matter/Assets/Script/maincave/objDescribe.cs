using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objDescribe : MonoBehaviour
{
    public GameObject objectPanel, PanelImage, PanelTitle, PanelText;
    public Sprite[] objectsTexture;
    public List<string> objectTitle;
    public List<string> objectDescribe;
    public bool inPanel;

    void Start()
    {
        objectTitle.Add("護身符");
        objectTitle.Add("斧頭");
        objectTitle.Add("醫藥書");
        objectTitle.Add("儲物櫃");
        objectTitle.Add("能量飲料");
        objectTitle.Add("急救箱");
        objectTitle.Add("手電筒");
        objectTitle.Add("食物");
        objectTitle.Add("腎上腺素");
        objectTitle.Add("香菇");
        objectTitle.Add("步槍");
        objectTitle.Add("返魂香");
        objectTitle.Add("相片");
        objectTitle.Add("水");

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
            objectPanel.GetComponent<Animator>().Play("panel-zoom-in");
        }
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
