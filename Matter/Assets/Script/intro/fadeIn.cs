using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeIn : MonoBehaviour
{
    SpriteRenderer rendS;
    SpriteRenderer rendS1, rendS2;
    Image rendI;
    Image rendI1, rendI2;
    Color c;
    Color c1, c2;

    
    char rendStat;

    int r1stat, r2stat;
    // Start is called before the first frame update

    void Start()
    {
        
    }
    public void fadell(GameObject tempfadeobj)
    {   

        rendS = tempfadeobj.GetComponent<SpriteRenderer>();
        if (rendS == null)
        {
            rendI = tempfadeobj.GetComponent<Image>();
            c = rendI.material.color;
            rendStat = 'i';
        }
        else 
        {
            c = rendS.material.color;
            rendStat = 's';
        }
        
        c.a = 0;
        StartCoroutine(fade());
    }

    public void fadedb(GameObject tmpfadeob1, GameObject tmpfadeob2)
    {
        rendS1 = tmpfadeob1.GetComponent<SpriteRenderer>();
        if (rendS1 == null)
        {
            rendI1 = tmpfadeob1.GetComponent<Image>();
            c1 = rendI1.material.color;
            r1stat = 0;
        }
        else 
        {
            c1 = rendS1.material.color;
            r1stat = 1;
        }

        rendS2 = tmpfadeob2.GetComponent<SpriteRenderer>();
        if (rendS2 == null)
        {
            rendI2 = tmpfadeob2.GetComponent<Image>();
            c2 = rendI2.material.color;
            r2stat = 0;
        }
        else 
        {
            c2 = rendS2.material.color;
            r2stat = 1;
        }
        
        c1.a = 0;
        c2.a = 0;
        StartCoroutine(fadedouble());
    }

    IEnumerator fade()
    {
        
        for (float f = 0F ; f <= 1f; f += 0.05f)
        {
            if (rendStat == 'i')
            {
                c = rendI.material.color;
                c.a = f;
                rendI.material.color = c;
            }
            else if (rendStat == 's')
            {
                c = rendS.material.color;
                c.a = f;
                rendS.material.color = c;
            }            
            yield return new WaitForSeconds(0.05f);
        }
        
    }

    IEnumerator fadedouble()
    {
        for (float f = 0F ; f <= 1f; f += 0.05f)
        {
            if (r1stat == 0)
            {
                c1 = rendI1.material.color;
                c1.a = f;
                rendI1.material.color = c1;
            }
            else if (r1stat == 1)
            {
                c1 = rendS1.material.color;
                c1.a = f;
                rendS1.material.color = c1;
            }   

            if (r2stat == 0)
            {
                c2 = rendI2.material.color;
                c2.a = f;
                rendI2.material.color = c2;
            }
            else if (r2stat == 1)
            {
                c2 = rendS2.material.color;
                c2.a = f;
                rendS2.material.color = c2;
            }        
            yield return new WaitForSeconds(0.05f);
            Debug.Log(c1.a);
            Debug.Log(c2.a);
        }
    }
}
