using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryController : MonoBehaviour
{
    public int currentSlot;
    public List<GameObject> items = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        currentSlot = -1;
        items.Clear();
    }

    public bool addItem()
    {
        currentSlot ++;
        if (currentSlot > 8 || currentSlot == -2)
        {
            currentSlot = -3; // change when can use item
            return false;
        }
        else
        {
            return true;
        }   
    }
}
