using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showscript : MonoBehaviour
{
    public GameObject dpti, dpsub, block;
    public Animator dptia, dpsuba;
    public List<string> title, subti, anim;
    public List<int> animSp;
    Color fade;

    void Start()
    {
        title.Add("Sloth Studios");
        subti.Add("Presents");
        anim.Add("fade");
        animSp.Add(1);

        title.Add("Chingshin Academy");
        subti.Add("In association with");
        anim.Add("fade");
        animSp.Add(1);

        title.Add("Project: Matter");
        subti.Add("");
        anim.Add("fade");
        animSp.Add(4);

        StartCoroutine(sequence());
    }
    void Update()
    {

    }

    IEnumerator sequence()
    {
        //yield return new WaitForSeconds(1);
        block.SetActive(false);

        for (int i = 0; i < 10; i++)
        {
            dpti.GetComponent<Text>().text = title[i];
            dpsub.GetComponent<Text>().text = subti[i];
            if (anim[0] == "fade")
            {
                StartCoroutine(fadetxt(animSp[i]));
            }
            yield return new WaitForSeconds(2 + animSp[i]);
        }
    }


    IEnumerator fadetxt(int waitTime)
    {
        dptia.Play("suf");
        dpsuba.Play("sufo");
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(waitTime);
        dptia.Play("sufo");
        dpsuba.Play("tifo");
    }

}
