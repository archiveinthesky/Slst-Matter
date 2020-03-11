using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControl : MonoBehaviour
{
    public GameObject mainCamera;
    private int limitLeft, limitRight;
    private float nowPos, originalPos, camOPos;
    private bool wasTouched;
    Touch touch;
    void Start()
    {
        limitLeft = 0;
        limitRight = 2100;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.touchCount);
        if (Input.touchCount > 0)
        {
            if (wasTouched)
            {
                nowPos = touch.position.x;
                mainCamera.GetComponent<Transform>().position = ();
            }
            else
            {
                wasTouched = true;
                originalPos = touch.position.x;
                camOPos = mainCamera.GetComponent<Transform>().position.x;
            }
            touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0;
            touchPos.y = 0;
            mainCamera.GetComponent<Transform>().position = touchPos;
            Debug.Log(touchPos);
        }
        else
        {
            wasTouched = false;
        }
    }
}
