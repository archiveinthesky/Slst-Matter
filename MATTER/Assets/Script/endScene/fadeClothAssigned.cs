using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeClothAssigned : MonoBehaviour
{
    public void fadeindone()
    {
        gameObject.SetActive(false);
    }

    public void fadeOutDone()
    {
        SceneManager.LoadScene("menu");
    }
}
