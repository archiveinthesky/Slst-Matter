using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickController : MonoBehaviour
{
    Vector2 mouse_pos;
    Vector3 g_mouse_pos;
    public bool follow_mouse = false;
    public Camera g_cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse_pos = Input.mousePosition;
        g_mouse_pos = g_cam.ScreenToWorldPoint(mouse_pos);
        if (follow_mouse) transform.position = g_mouse_pos;
    }

    public void followMouse()
    {
        follow_mouse = true;
    }

    public void unfollowMouse()
    {
        follow_mouse = false;
    }
}
