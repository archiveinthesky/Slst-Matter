using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControl : MonoBehaviour
{
    public GameObject mainCamera;
    private int limitLeft, limitRight;
    private float nowPos, originalPos, oriMousePos, camOPos;
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
        //Debug.Log(Input.touchCount);

        if (Input.touchCount > 0 && !GetComponent<objDescribe>().inPanel)
        {
            touch = Input.GetTouch(0);
            if (wasTouched)
            {
                nowPos = touch.position.x;
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
                oriMousePos = Input.mousePosition.x;
                camOPos = mainCamera.GetComponent<Transform>().position.x;
            }


        }
        else
        {
            wasTouched = false;
        }

        if (Input.GetKey("a"))
        {
            mainCamera.GetComponent<Transform>().position = new Vector3(mainCamera.GetComponent<Transform>().position.x - 10, mainCamera.GetComponent<Transform>().position.y, mainCamera.GetComponent<Transform>().position.z);
        }
        else if (Input.GetKey("d"))
        {
            mainCamera.GetComponent<Transform>().position = new Vector3(mainCamera.GetComponent<Transform>().position.x + 10, mainCamera.GetComponent<Transform>().position.y, mainCamera.GetComponent<Transform>().position.z);
        }

        if (mainCamera.GetComponent<Transform>().position.x < 0)
        {
            mainCamera.GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
        else if (mainCamera.GetComponent<Transform>().position.x > 2100)
        {
            mainCamera.GetComponent<Transform>().position = new Vector3(2100, 0, 0);
        }
    }


}
