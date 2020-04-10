using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectManager : MonoBehaviour
{
    public List<GameObject> allObjs;
    public List<int> caveObjects;
    public List<GameObject> foods;
    public List<GameObject> waters;
    int counter;

    void Start()
    {
        
        caveObjects.Add(1); //amulet id:1
        caveObjects.Add(1); //axe id:2
        caveObjects.Add(1); //book id:3
        caveObjects.Add(1); //cabinet id:4
        caveObjects.Add(1); //energyDrink id:5
        caveObjects.Add(1); //firstAid id:6
        caveObjects.Add(1); //flashLight id:7
        caveObjects.Add(GetComponent<lifeData>().getVal("o")); //food id:8
        caveObjects.Add(1); //hypePills id:9
        caveObjects.Add(1); //mushroom id:10
        caveObjects.Add(1); //rifle id:11
        caveObjects.Add(1); //solveFlower id:12
        caveObjects.Add(1); //wallPic id:13
        caveObjects.Add(GetComponent<lifeData>().getVal("a")); //water id:14

        eatableStuffShow();
    }

    void Update()
    {
        counter += 1;
        if (counter == 60)
        {
            eatableStuffShow();
            for (int i = 0; i < allObjs.Count; i++)
            {
                if (caveObjects[i] == 0)
                {
                    allObjs[i].SetActive(false);
                }
                else
                {
                    allObjs[i].SetActive(true);
                }
            }
            counter = 0;
        }
    }

    void eatableStuffShow()
    {
        caveObjects[7] = GetComponent<lifeData>().getVal("o");
        caveObjects[13] = GetComponent<lifeData>().getVal("a");
        for (int i = 0; i < 6; i++)
        {
            if (i + 1 > GetComponent<lifeData>().getVal("o"))
            {
                foods[i].SetActive(false);
            }
            else
            {
                foods[i].SetActive(true);
            }
        }

        for (int i = 0; i < 6; i++)
        {
            if (i + 1 > GetComponent<lifeData>().getVal("a"))
            {
                waters[i].SetActive(false);
            }
            else
            {
                waters[i].SetActive(true);
            }
        }
    }

    public int returnObjsVal(int objectID)
    {
        return caveObjects[objectID - 1];
    }

    public void setObjsVal(int objectID, int newValue)
    {
        caveObjects[objectID - 1] = newValue;
    }
}
