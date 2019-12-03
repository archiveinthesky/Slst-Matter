using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeIn : MonoBehaviour
{
    SpriteRenderer rend;
    Color c;

    // Start is called before the first frame update

    void Start()
    {
        
    }
    public void fadell(GameObject tempfadeobj)
    {   

        rend = tempfadeobj.GetComponent<SpriteRenderer>();
        c = rend.material.color;
        c.a = 0;
        StartCoroutine(fade());
    }

    IEnumerator fade()
    {
        
        for (float f = 0F ; f <= 1f; f += 0.05f)
        {
            c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
        c.a = 0f;
    }
}
