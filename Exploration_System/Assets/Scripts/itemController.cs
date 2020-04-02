using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    public GameObject inventory_bar;
    inventoryController inventory_controller;
    // Start is called before the first frame update
    void Start()
    {
        inventory_controller = inventory_bar.GetComponent<inventoryController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.name == "Player")
        {
            if (inventory_controller.addItem())
            { // sucess
                // x 8.23f y 4.3+currentSlot*4.3f
                Destroy(GetComponent<PolygonCollider2D>());
                iTween.MoveTo(gameObject, iTween.Hash("x", 8.23f, "y", 4.3f-(inventory_controller.currentSlot * 1.08f)));
            }
            else {} // no more slots
        }
    }
}
