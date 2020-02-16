using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionsMenu : MonoBehaviour
{
    public GameObject settingsgb, menuctrl;
    public void entermenu()
    {
        StartCoroutine(passiveEnterMenu());
    }

    public void exitmenu()
    {
        StartCoroutine(passiveExitMenu());
    }

    IEnumerator passiveEnterMenu()
    {
        for (int i = 0; i<10; i++)
        {
            settingsgb.GetComponent<Transform>().Rotate(0,0,i);
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator passiveExitMenu()
    {
        Debug.Log("oM exit called");
        for (int i = 10; i>0; i--)
        {
            settingsgb.GetComponent<Transform>().Rotate(0,0,i);
            yield return new WaitForSeconds(0.05f);
        }
        menuctrl.GetComponent<menuController>().returnFromMenu();
    }
}
