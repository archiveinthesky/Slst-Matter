using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fadeob1, slothtext;
    void Start()
    {
        StartCoroutine(slothlogo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator slothlogo()
    {
        gameObject.GetComponent<fadeIn>().fadell(fadeob1);
        iTween.MoveTo(slothtext, iTween.Hash("x", 580, "time", 1, "delay", 1.2f, "easetype", "Math.easeOutCirc"));
        iTween.MoveTo(fadeob1, iTween.Hash("x", 270, "time", 1, "delay", 1.2f, "easetype", "Math.easeOutCirc"));
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<fadeout>().fadeoutpub(fadeob1);
        yield return new WaitForSeconds(1.5f);
        gameObject.GetComponent<fadeout>().fadeoutpub(slothtext);   
    }
}
