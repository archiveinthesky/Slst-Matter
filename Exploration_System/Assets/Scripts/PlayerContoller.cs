using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos;

        if (Input.GetKey(KeyCode.W))
        {
            move_player(0, 750);
        }
        if (Input.GetKey(KeyCode.A))
        {
            move_player(-750, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            move_player(0, -750);
        }
        if (Input.GetKey(KeyCode.D))
        {
            move_player(750, 0);
        }
    }

    public void move_player(float x, float y)
    {
        pos.x += x/2500;
        pos.y += y/2500;
    }
}
