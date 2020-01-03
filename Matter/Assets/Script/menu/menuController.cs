using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
    public Animator logosequenceanim, canvasanim;
    public GameObject logogo;
    public GameObject startgamebtn, contamebtn, gameoptibtn;
    public GameObject chosesavegobj, csslot1, csslot2, csslot3;
    private int slotstatus;
    // Start is called before the first frame update
    void Start()
    {
        slotstatus = 0;
        StartCoroutine(appearmenu());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startgame()
    {   
        slotstatus = 1;
        this.GetComponent<datacontrolmenu>().setslotvalues();
        StartCoroutine(clickleave());
        StartCoroutine(saveloadmenuin());
    }

    public void continuegame()
    {
        slotstatus = 2;
        this.GetComponent<datacontrolmenu>().setslotvalues();
        StartCoroutine(clickleave());
        StartCoroutine(saveloadmenuin());
    }

    public void gameoptions()
    {
        StartCoroutine(clickleave());
    }


    IEnumerator appearmenu()
    {
        //logosequenceanim.Play("logo");
        //yield return new WaitForSeconds(5);
        canvasanim.Play("btnfadesequence");
        yield return new WaitForSeconds(1.7f);
        startgamebtn.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        contamebtn.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        gameoptibtn.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
    }

    IEnumerator clickleave()
    {   
        Destroy(logogo);
        startgamebtn.GetComponent<menubutton>().exit();
        yield return new WaitForSeconds(0.1f);
        contamebtn.GetComponent<menubutton>().exit();
        yield return new WaitForSeconds(0.1f);
        gameoptibtn.GetComponent<menubutton>().exit();
        yield return new WaitForSeconds(0.1f);

    }

    IEnumerator saveloadmenuin()
    {
        //Debug.Log("exeing");
        yield return new WaitForSeconds(0.4f);
        chosesavegobj.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        csslot1.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        csslot2.GetComponent<menubutton>().appear();
        yield return new WaitForSeconds(0.1f);
        csslot3.GetComponent<menubutton>().appear();
        
    }

    public void slotonbtnclick(int callslotval)
    {
        if (slotstatus == 1){
            this.GetComponent<datacontrolmenu>().createnewgame(callslotval);
        } else if (slotstatus == 2) {
            this.GetComponent<datacontrolmenu>().continuegame(callslotval);
        }
    }
}
