using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class determinePass : MonoBehaviour
{
    void Start()
    {
        GetComponent<Animator>().Play("logo");
        if (PlayerPrefs.GetInt("doneNewPlayer") == 0)
        {
            PlayerPrefs.SetInt("doneNewPlayer", -1);
        }
    }

    public void doneIntro()
    {
        if (PlayerPrefs.GetInt("doneNewPlayer") == -1)
        {
            SceneManager.LoadScene("newPlayers");
        }
        else
        {
            SceneManager.LoadScene("menu");
        }
    }


}
