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
    public Texture2D[] tex2darray;
    void Start()
    {
        limitLeft = 0;
        limitRight = 2100;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.touchCount);
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (wasTouched)
            {
                Debug.Log("was touched");
                nowPos = touch.position.x;
                Debug.Log(mainCamera.GetComponent<Transform>().position.x);
                mainCamera.GetComponent<Transform>().position = new Vector3(camOPos - nowPos + originalPos, 0, 0);
                if (mainCamera.GetComponent<Transform>().position.x < 0)
                {
                    mainCamera.GetComponent<Transform>().position = new Vector3(0, 0, 0);
                }
                else if (mainCamera.GetComponent<Transform>().position.x > 2100)
                {
                    mainCamera.GetComponent<Transform>().position = new Vector3(2100, 0, 0);
                }
            }
            else
            {
                wasTouched = true;
                originalPos = touch.position.x;
                camOPos = mainCamera.GetComponent<Transform>().position.x;
            }

        }
        else
        {
            wasTouched = false;
        }
    }


    void blash()
    {

    }
}
