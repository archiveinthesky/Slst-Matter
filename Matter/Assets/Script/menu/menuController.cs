using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
    public GameObject logointro;
    public GameObject canvas, background, backgroundR, logo, startGame, options;
    public GameObject slttl, backbtn, sl1, sl2, sl3;
    private int done;
    public bool enableLogoAnimation;
    void Start()
    {
        canvas.SetActive(false);
        slttl.SetActive(false);
        sl1.SetActive(false);
        sl2.SetActive(false);
        sl3.SetActive(false);
        backbtn.SetActive(false);
        done = 0;
        if (enableLogoAnimation){ logointro.SetActive(true); playlogo();}
        else{canvasin();}
    }

    void playlogo()
    {
        logointro.GetComponent<Animator>().Play("logo");
    }

    public void canvasin()
    {
        StartCoroutine(passiveCanvasin());
    }

    public void canvasout()
    {
        StartCoroutine(passiveCanvasout());
    }

    public void choseSlot()
    {
        StartCoroutine(passiveCanvasout());
        GetComponent<datacontrol>().setslotvals();
        StartCoroutine(passiveCallSlot());
    }

    public void backSlot()
    {
        StartCoroutine(passiveExitSlot());
    }

    public void showoptions()
    {
        StartCoroutine(passiveCanvasout());
    }

    // passive programs below -------------------------------------------------

    IEnumerator passiveCanvasin()
    {   
        done = 0;
        canvas.SetActive(true);
        logo.SetActive(false);
        startGame.SetActive(false);
        options.SetActive(false);
        backgroundR.SetActive(false);
        //yield return new WaitForSeconds(1.5f);
        backgroundR.SetActive(true);
        logo.transform.position = new Vector3(276,logo.transform.position.y,logo.transform.position.z);
        logo.SetActive(true);
        iTween.MoveTo(logo, iTween.Hash("x", -430, "time", 1.7f));
        backgroundR.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        startGame.SetActive(true);
        startGame.GetComponent<Animator>().Play("startgame-intro-fade");
        yield return new WaitForSeconds(0.5f);
        options.SetActive(true);
        options.GetComponent<Animator>().Play("options-intro-fade");
        yield return new WaitForSeconds(1.2f);
        done = 1;
    }

    IEnumerator passiveCanvasout()
    {
        done = 0;
        iTween.MoveTo(logo, iTween.Hash("x", -2000, "time", 1.0f));
        //yield return new WaitForSeconds(0.3f);
        startGame.GetComponent<Animator>().Play("startgame-outro-fade");
        yield return new WaitForSeconds(0.2f);
        options.GetComponent<Animator>().Play("options-outro-fade");
        yield return new WaitForSeconds(1.1f);
        logo.SetActive(false);
        startGame.SetActive(false);
        options.SetActive(false);
        done = 1;
    }

    IEnumerator passiveCallSlot()
    {
        yield return new WaitForSeconds(1.8f);
        slttl.SetActive(true);
        backbtn.SetActive(true);
        slttl.GetComponent<Animator>().Play("slttl-intro-fade");
        backbtn.GetComponent<Animator>().Play("slotBack-intro-fade");
        yield return new WaitForSeconds(0.2f);
        sl1.SetActive(true);
        sl1.GetComponent<Animator>().Play("s1-intro-fade");
        yield return new WaitForSeconds(0.2f);
        sl2.SetActive(true);
        sl2.GetComponent<Animator>().Play("s2-intro-fade");
        yield return new WaitForSeconds(0.2f);
        sl3.SetActive(true);
        sl3.GetComponent<Animator>().Play("s3-intro-fade");
    }

    IEnumerator passiveExitSlot()
    {
        done = 0;
        slttl.GetComponent<Animator>().Play("slttl-outro-fade");
        backbtn.GetComponent<Animator>().Play("slotBack-outro-fade");
        yield return new WaitForSeconds(0.2f);
        sl1.GetComponent<Animator>().Play("s1-outro-fade");
        yield return new WaitForSeconds(0.2f);
        sl2.GetComponent<Animator>().Play("s2-outro-fade");
        yield return new WaitForSeconds(0.2f);
        sl3.GetComponent<Animator>().Play("s3-outro-fade");
        yield return new WaitForSeconds(1);
        slttl.SetActive(false);
        backbtn.SetActive(false);
        sl1.SetActive(false);
        sl2.SetActive(false);
        sl3.SetActive(false);
        canvasin();
    }
}
