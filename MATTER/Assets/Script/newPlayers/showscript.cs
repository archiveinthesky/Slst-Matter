using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class showscript : MonoBehaviour
{
    public GameObject dpti, dpsub, block;
    public Animator dptia, dpsuba, blocka;
    public List<string> title, subti, anim;
    public List<float> animSp;


    void Start()
    {
        title.Add("樹懶工作室");
        subti.Add("為您呈現");
        anim.Add("fade");
        animSp.Add(2f);

        title.Add("臺北市私立靜心高級中學");
        subti.Add("指導");
        anim.Add("fade");
        animSp.Add(2f);

        title.Add("Matter: 末日生存");
        subti.Add("");
        anim.Add("fade");
        animSp.Add(4f);

        title.Add("西元2025年，世界上最大的藥廠，創世公司");
        subti.Add("");
        anim.Add("type");
        animSp.Add(0.1f);

        title.Add("研發出了癌症的對抗藥物");
        subti.Add("");
        anim.Add("type");
        animSp.Add(0.1f);

        title.Add("你身為開發團隊的首席科學家");
        subti.Add("");
        anim.Add("type");
        animSp.Add(0.1f);

        title.Add("獲得了媒體大量的關注");
        subti.Add("");
        anim.Add("type");
        animSp.Add(0.1f);

        title.Add("然而，三個月後，服用藥物的病患卻集體昏迷");
        subti.Add("");
        anim.Add("type");
        animSp.Add(0.1f);

        title.Add("為了應付這個突發狀況");
        subti.Add("");
        anim.Add("type");
        animSp.Add(0.1f);

        title.Add("公司急忙將你送回提煉解藥的植物的叢林");
        subti.Add("");
        anim.Add("type");
        animSp.Add(0.1f);
        StartCoroutine(sequence());
    }

    IEnumerator sequence()
    {
        //yield return new WaitForSeconds(1);
        block.SetActive(true);

        for (int i = 0; i < title.Count; i++)
        {
            dpti.GetComponent<Text>().text = title[i];
            dpsub.GetComponent<Text>().text = subti[i];
            if (anim[i] == "fade")
            {
                StartCoroutine(fadetxt(animSp[i]));
                yield return new WaitForSeconds(2 + animSp[i]);
            }
            else if (anim[i] == "type")
            {
                StartCoroutine(typetxt(animSp[i], title[i], subti[i]));
                yield return new WaitForSeconds(animSp[i] * (title[i].Length + subti[i].Length) + 2);
            }

        }

        yield return new WaitForSeconds(1);
        PlayerPrefs.SetInt("doneNewPlayer", 1);
        SceneManager.LoadScene("menu");

        dpsub.SetActive(false);
        dpti.SetActive(false);


    }


    IEnumerator fadetxt(float waitTime)
    {
        block.SetActive(true);
        blocka.Play("block-fade-out");
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(waitTime);
        blocka.Play("block-fade-in");
    }

    IEnumerator typetxt(float delayTime, string showTextTitle, string showTextSub)
    {
        block.SetActive(true);
        dpti.GetComponent<Text>().text = "";
        dpsub.GetComponent<Text>().text = "";
        block.SetActive(false);
        for (int j = 0; j < showTextTitle.Length; j++)
        {
            dpti.GetComponent<Text>().text = dpti.GetComponent<Text>().text + showTextTitle[j].ToString();
            yield return new WaitForSeconds(delayTime);
        }
        for (int j = 0; j < showTextSub.Length; j++)
        {
            dpsub.GetComponent<Text>().text = dpsub.GetComponent<Text>().text + showTextSub[j].ToString();
            yield return new WaitForSeconds(delayTime);
        }
    }

}
