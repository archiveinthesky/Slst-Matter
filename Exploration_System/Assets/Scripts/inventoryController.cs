using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryController : MonoBehaviour
{
    public int currentSlot;
    public List<bool> occupied = new List<bool>();
    // Start is called before the first frame update
    void Start()
    {
        currentSlot = -1;
        occupied.Clear();
    }

    public bool addItem()
    {
        currentSlot ++;
        if (currentSlot > 8 || currentSlot == -2)
        {
            for (int i = 0; i < )
            currentSlot = -3; // change when can use item
            return false;
        }
        else
        {
            occupied.Add()
            return true;
        }   
    }
}
