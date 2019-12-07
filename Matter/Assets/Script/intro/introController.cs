using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introController : MonoBehaviour
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
        iTween.MoveTo(slothtext, iTween.Hash("x", 500, "time", 1, "delay", 1.2f, "easetype", "easeOutCirc"));
        iTween.MoveTo(blayer, iTween.Hash("x", -800, "time", 1, "delay", 1.2f, "easetype", "easeOutCirc"));
        iTween.MoveTo(fadeob1, iTween.Hash("x", -350, "time", 1, "delay", 1.2f, "easetype", "easeOutCirc"));
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<fadeout>().fadeoutsg(blayer);
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<fadeout>().fadeoutpub(slothtext, fadeob1);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);

    }
    


    
}
