using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuController : MonoBehaviour
{
    public Animator logosequenceanim;
    public GameObject introblack;
    public GameObject startgamebtn, contamebtn, gameoptibtn;
    public GameObject chosesavegobj, csslot1, csslot2, csslot3;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(appearmenu());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startgame()
    {
        StartCoroutine(clickleave());
        StartCoroutine(saveloadmenuin());
    }

    public void continuegame()
    {
        StartCoroutine(clickleave());
        StartCoroutine(saveloadmenuin());
    }

    public void gameoptions()
    {
        StartCoroutine(clickleave());
    }



    IEnumerator appearmenu()
    {
        logosequenceanim.Play("logo");
        yield return new WaitForSeconds(5);
        introblack.GetComponent<SpriteRenderer>().color = new Vector4(0,0,0,0);
        startgamebtn.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        contamebtn.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        gameoptibtn.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
    }

    IEnumerator clickleave()
    {
        startgamebtn.GetComponent<menubutton>().exit();
        yield return new WaitForSeconds(0.1f);
        contamebtn.GetComponent<menubutton>().exit();
        yield return new WaitForSeconds(0.1f);
        gameoptibtn.GetComponent<menubutton>().exit();
        yield return new WaitForSeconds(0.1f);

    }

    IEnumerator saveloadmenuin()
    {
        Debug.Log("exeing");
        yield return new WaitForSeconds(0.4f);
        //chosesavegobj.GetComponent<menubutton>().appear();
        //yield return new WaitForSeconds(0.1f);
        csslot1.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        csslot2.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        csslot3.GetComponent<menubutton>().appear();
        
    }
}
