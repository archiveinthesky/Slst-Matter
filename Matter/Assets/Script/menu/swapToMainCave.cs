using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swapToMainCave : MonoBehaviour
{
    public void swtichToCave()
    {
        SceneManager.LoadScene(sceneName: "maincave");
    }
}
