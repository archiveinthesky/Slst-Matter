using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickController : MonoBehaviour
{
    Vector2 mouse_pos;
    public bool follow_mouse = false;
    Vector2 original_pos;
    public GameObject player;
    PlayerContoller player_script;

    // Start is called before the first frame update
    void Start()
    {
        original_pos = GetComponent<RectTransform>().position;
        player_script = player.GetComponent<PlayerContoller>();
    }

    // Update is called once per frame
    void Update()
    {
        mouse_pos = Input.mousePosition;
        if (follow_mouse) GetComponent<RectTransform>().anchoredPosition = Vector2.ClampMagnitude(mouse_pos-original_pos, 200);
        if (Input.GetButtonDown("Fire1")) followMouse();

        player_script.move_player(GetComponent<RectTransform>().anchoredPosition.x, GetComponent<RectTransform>().anchoredPosition.y);
    }

    public void followMouse()
    {
        follow_mouse = true;
        StartCoroutine(co());
    }

    public void unfollowMouse()
    {
        follow_mouse = false;
        GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
    }

    IEnumerator co()
    {
        yield return new WaitUntil(() => Input.GetButtonUp("Fire1"));
        unfollowMouse();
    }

    void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log("colliding"); 
    }
}
