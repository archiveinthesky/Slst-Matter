using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManagement : MonoBehaviour
{
    public CommonData gd;
    public List<string> objectTitle, objectDescribe, objectApply;
    public List<int> objectCount;
    public CommonData gd;
    

    private float nowPos, originalPos, oriMousePos, camOPos;
    private bool wasTouched;
    Touch touch;
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

        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);
        objectCount.Add(0);

        loaddata();
    }

    void loaddata()
    {
        for (int i = 0; i < objectCount.Count; i++)
        {
            objectCount[i] = PlayerPrefs.GetInt("om" + gd.saveslot + "_cnt_" + i);
        }
    }

    void savedata()
    {
        for (int i = 0; i < objectCount.Count; i++)
        {
            PlayerPrefs.SetInt("om" + gd.saveslot + "_cnt_" + i, objectCount[i]);
        }
    }

    public List<string> recieveObjectData(int id)
    {
        var re = new List<string>();
        re.Add(objectTitle[id]);
        re.Add(objectDescribe[id]);
        re.Add(objectApply[id]);
        return re;
    }

    public int ItemUsed(int id)
    {
        if (objectCount[id] > 0)
        {
            switch (id)
            {
                case 5:
                    objectCount[id] -= 1;


            }
            return 1;
        }
        else
        {
            return 0;
        }

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (wasTouched)
            {
                nowPos = touch.position.x;
                Camera.main.GetComponent<Transform>().position = new Vector3(camOPos - nowPos + originalPos, 0, 0);
                if (Camera.main.GetComponent<Transform>().position.x < 0)
                {
                    Camera.main.GetComponent<Transform>().position = new Vector3(0, 0, 0);
                }
                else if (Camera.main.GetComponent<Transform>().position.x > 2100)
                {
                    Camera.main.GetComponent<Transform>().position = new Vector3(2100, 0, 0);
                }
            }
            else
            {
                wasTouched = true;
                originalPos = touch.position.x;
                oriMousePos = Input.mousePosition.x;
                camOPos = Camera.main.GetComponent<Transform>().position.x;
            }


        }
        else
        {
            wasTouched = false;
        }



        if (Input.GetKey("a"))
        {
            Camera.main.GetComponent<Transform>().position = new Vector3(Camera.main.GetComponent<Transform>().position.x - 10, Camera.main.GetComponent<Transform>().position.y, Camera.main.GetComponent<Transform>().position.z);
        }
        else if (Input.GetKey("d"))
        {
            Camera.main.GetComponent<Transform>().position = new Vector3(Camera.main.GetComponent<Transform>().position.x + 10, Camera.main.GetComponent<Transform>().position.y, Camera.main.GetComponent<Transform>().position.z);
        }

        if (Camera.main.GetComponent<Transform>().position.x < 0)
        {
            Camera.main.GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
        else if (Camera.main.GetComponent<Transform>().position.x > 2100)
        {
            Camera.main.GetComponent<Transform>().position = new Vector3(2100, 0, 0);
        }
    }


}
