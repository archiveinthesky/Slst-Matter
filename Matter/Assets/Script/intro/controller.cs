using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fadeob1, slothtext, blayer;
    void Start()
    {
        StartCoroutine(slothlogo());
        //StartCoroutine(mainmenuin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator slothlogo()
    {
        gameObject.GetComponent<fadeIn>().fadell(fadeob1);
        iTween.MoveTo(slothtext, iTween.Hash("x", 400, "time", 1, "delay", 1.2f, "easetype", "easeOutCirc"));
        iTween.MoveTo(blayer, iTween.Hash("x", -800, "time", 1, "delay", 1.2f, "easetype", "easeOutCirc"));
        iTween.MoveTo(fadeob1, iTween.Hash("x", -253, "time", 1, "delay", 1.2f, "easetype", "easeOutCirc"));
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<fadeout>().fadeoutsg(blayer);
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<fadeout>().fadeoutpub(slothtext, fadeob1);

    }
    


    
}
