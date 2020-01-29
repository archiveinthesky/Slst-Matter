using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
    public GameObject logointro;
    public GameObject canvas, startSlotGame, optionsBtn;
    void Start()
    {
        canvas.SetActive(false);
        playlogo();
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

    // passive programs below -------------------------------------------------

    IEnumerator passiveCanvasin()
    {   
        canvas.SetActive(true);
        canvas.GetComponent<Animator>().Play("canvas-intro-fade");
        yield return new WaitForSeconds(2.3f);
        startSlotGame.GetComponent<Animator>().Play("enterSlot-intro-fade");
        yield return new WaitForSeconds(1);
        optionsBtn.GetComponent<Animator>().Play("optionsBtn-intro-fade");
    }

    IEnumerator passiveCanvasout()
    {
        canvas.GetComponent<Animator>().Play("canvas-outro-fade");
        yield return new WaitForSeconds(1);
    }
}
