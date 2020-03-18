using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionsMenu : MonoBehaviour
{
    public GameObject settingsgb, menuctrl, preventImage;
    private bool inmenu, inAnimation;

    void Awake()
    {
        preventImage.SetActive(false);
        inAnimation = false;
    }

    public void nowInAnimation()
    {
        inAnimation = true;
    }

    public void AnimationDone()
    {
        inAnimation = false;
    }
    public void entermenu()
    {
        if (!inmenu){
        StartCoroutine(passiveEnterMenu());
        }
    }

    public void exitmenu()
    {
        if (inmenu){
        StartCoroutine(passiveExitMenu());
        }

    }

    IEnumerator passiveEnterMenu()
    {
        preventImage.SetActive(true);
        for (int i = 0; i<10; i++)
        {
            settingsgb.GetComponent<Transform>().Rotate(0,0,i);
            yield return new WaitForSeconds(0.05f);
        }
        inmenu = true;
    }

    IEnumerator passiveExitMenu()
    {
        for (int i = 10; i>0; i--)
        {
            settingsgb.GetComponent<Transform>().Rotate(0,0,-i);
            yield return new WaitForSeconds(0.05f);
        }
        inmenu = false;
        menuctrl.GetComponent<menuController>().returnFromMenu();
        preventImage.SetActive(false);
    }
}
