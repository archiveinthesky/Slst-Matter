using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menubutton : MonoBehaviour
{
    public Animator animator;
    public int hideonstart;
    public int objtype;
    private float originaly;

    // Start is called before the first frame update
    void Start()
    {
        originaly = this.GetComponent<RectTransform>().position.y;
        if (hideonstart == 1)
        {
            gameObject.GetComponent<RectTransform>().position = new Vector3(gameObject.GetComponent<RectTransform>().position.x, 2000, gameObject.GetComponent<RectTransform>().position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void appear()
    {
        if (hideonstart == 1)
        {
            gameObject.GetComponent<RectTransform>().position = new Vector3(gameObject.GetComponent<RectTransform>().position.x, originaly, gameObject.GetComponent<RectTransform>().position.z);

        }
        
        
        
        if (objtype == 0)
        {
            animator.Play("fadein");
        }
        else if (objtype == 1)
        {
            animator.Play("fadeinslot");
        }
        
    }

    public void exit()
    {
        animator.Play("press");
    }

    void destroyself()
    {
         Destroy(gameObject);
    }
}
