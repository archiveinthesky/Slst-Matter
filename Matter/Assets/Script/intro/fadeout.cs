using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout : MonoBehaviour
{
    SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void fadeoutpub(GameObject tempfadeout)
    {
        rend = tempfadeout.GetComponent<SpriteRenderer>();
        StartCoroutine(fade());
    }

    IEnumerator fade()
    {
        
        Color c = rend.material.color;
        for (float f = 1f ; f >= 0; f -= 0.05f)
        {
            c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
            Debug.Log(c.a);
        }
        c.a = 0f;
        Debug.Log(c.a);
    }
}
