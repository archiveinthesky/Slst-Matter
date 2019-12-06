using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout : MonoBehaviour
{
    SpriteRenderer rend, rend1, rend2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void fadeoutsg(GameObject tempfadeout)
    {
        rend = tempfadeout.GetComponent<SpriteRenderer>();
        StartCoroutine(fadesg());
    }

    public void fadeoutpub(GameObject tempfadeout1, GameObject tempfadeout2)
    {
        rend1 = tempfadeout1.GetComponent<SpriteRenderer>();
        rend2 = tempfadeout2.GetComponent<SpriteRenderer>();
        StartCoroutine(fade());
    }

    IEnumerator fadesg()
    {
        
        Color c = rend.material.color;
        for (float f = 1f ; f >= 0; f -= 0.05f)
        {
            c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
            // Debug.Log(c1.a);
        }
        c.a = 0f;
        // Debug.Log(c.a);
    }

    IEnumerator fade()
    {
        
        Color c1 = rend1.material.color;
        Color c2 = rend2.material.color;
        for (float f = 1f ; f >= 0; f -= 0.05f)
        {
            c1 = rend1.material.color;
            c1.a = f;
            c2 = rend2.material.color;
            c2.a = f;
            rend1.material.color = c1;
            rend2.material.color = c2;
            yield return new WaitForSeconds(0.05f);
            // Debug.Log(c1.a);
        }
        c1.a = 0f;
        c2.a = 0f;
        // Debug.Log(c.a);
    }
}
