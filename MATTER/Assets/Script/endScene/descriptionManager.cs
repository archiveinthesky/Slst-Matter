using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class descriptionManager : MonoBehaviour
{
    public List<string> endingNames, endingDescriptions;
    public List<string> pagesList;
    public GameObject fadecloth, completeEnding, description, leftBtn, rightBtn;
    private int onPage;
    void Start()
    {
        fadecloth.SetActive(true);
        endingNames.Add("死亡");
        endingDescriptions.Add("你的生命值歸零了\n請重新開始遊戲吧");

        endingNames.Add("第?號實驗品");
        endingDescriptions.Add("軍官聽到你的答覆後面色並沒有什麼改變，只是你依然感受到他有些失落。告別了軍官後，你在回到基地的路上繼續搜索物資，不過走著就感到後頸被敲擊而失去了意識。你從昏迷中醒來，眼前一片悠藍，神智恢復後的你，發現自己被關在類似實驗槽的地方，想大聲呼救卻發現自己只能不斷的吐出泡沫，想要掙扎卻因身上扎滿了怵目驚心的管子而動彈不得，你就在這樣的狀況下再次失去了意識。");

        endingNames.Add("軍官的真面目");
        endingDescriptions.Add("軍官邀請你搭乘直升機前往避難所，值得注意的是軍用直升機上的徽章和你之前看到的那架墜落直升機不太相同，若之前的是代表救濟的紅色十字，那麼這架直升機就是六芒星，為什麼不同呢？你來不及思考太多，直升機已經抵達了【避難所】，看著眼前巨大的建築，你心中突然有一些不好的預感。金屬門緩緩地打開，你看到數以萬計的民眾蜷縮在角落顫抖，那樣的眼神並不是像在看著救世主，恐懼、害怕、退縮，彷彿眼前的軍官是比喪屍更加可怕的【惡魔】，想到這裡你不禁向後退。「為什麼要害怕呢？我明明是在救贖你們，你說是吧？」前方的軍官突然回頭看向你，他眼中閃爍的是【狂熱】。你當機立斷的向後逃走，不過已經來不及了，軍官命人將你捉住，並將你帶到了更深處的區域。你們來到像是實驗室的地方，裡面有許多穿著白色衣服的人員正在工作，而中心擺放著大量盛滿水的實驗槽，看到其中的景像你忍不住乾嘔，槽中擺放的東西是人。具體來說，是已經快被分解成肉塊的人。「怎麼樣？很棒吧？這些是我新世界的子民們哦，多麼美麗而又純潔的生物們呀!」你忍住一陣噁心感，詢問軍官的真實目的。「目的，救贖這醜惡的世界算不算，我知道的，你是想知道我的作法對吧？那麼我就從頭說起了，政府的工作是保護人民的權益，而我們這些士兵們當然也不例外，不過以我看來這是個愚昧的行為，人們根本不配的到幫助，幸好我的主給了指引，【創造新世界】，這不是很棒嗎？一切的起點就從這裡開始。」聽他說的話後你感到震驚，過去的種種此時連成了一線，公司的藥物問題、搜索中撿到的軍事資源、墜落的直升機、綠色的液體、返魂香、實驗體，他和公司合力不斷研發出延遲發作的病毒，誘導人們病毒具傳染性，將收容的人拿來進行實驗，當軍方靠近基地時就將他們秘密處理，掉落的物資也是，墜落的直昇機也是，他們不斷的投放喪屍，並研發新的生化武器，打算加速人類滅亡的速度，而【返魂香】無疑是病毒的解藥，而你卻將最後的希望交到了敵人手中。「看你的表情，我想你應該明白了，製藥公司什麼的從來就是個陰謀，我等待這一刻非常久了，現在就讓你看看我的最終成果吧!可憐的實驗品」");

        endingNames.Add("血染的返魂香");
        endingDescriptions.Add("「這可由不得你」軍官命令一旁的士兵將你扣上直升機，你很害怕，不過也無法抵抗，終於飛行到達了目的地，你猛力的開始掙扎，幾位軍人一時不察鬆開了你，你快速的將他們手中拿著的【返魂香】搶走，並且頭也不回的跑走了，但你並沒有注意到身後的軍官臉上那一抹詭異的笑容。跑了很久以後，你慢慢累得停了下來，當你鬆了口氣，以為擺脫了追兵時，突然聽見身後一陣巨響，視線逐漸被染紅，意識逐漸模糊，在閉上眼睛的前一刻，你似乎看到那位軍官緩緩向你走來。");

        endingNames.Add("疏忽");
        endingDescriptions.Add("正當你以為一切正在好轉時，異變突然發生，進行重建工作的人們開始發狂，身上長出了奇怪的肉塊，看似再次變成了喪屍，更加壯碩、強大，更具毀滅性，這一次已經無法阻止了，看著悲劇再次重演的你明白了前因後果，想起了那日的軍人們【他們的臂章不是一般的紅十字軍徽，而是六芒星】。在死亡來臨的前一刻，你多麼希望能倒回分歧的那一刻，就算沒有能力拯救世界，但至少也要知道事情的真相，讓自己能夠死得瞑目。");

        endingNames.Add("平庸的科學家");
        endingDescriptions.Add("你持續的在森林裡找了很久，但始終無法找到解藥。你的食物和水逐漸減少，最後你死在了叢林");

        fadecloth.GetComponent<Animator>().Play("fadecloth-fade-in");

        setTexts(PlayerPrefs.GetInt("endgameId"));
    }

    void setTexts(int id)
    {
        completeEnding.GetComponent<Text>().text += endingNames[id];
        string temp  = endingDescriptions[id];
        while (temp.Length > 108)
        {
            pagesList.Add(temp.Substring(0, 108));
            temp = temp.Substring(108);
        }
        pagesList.Add(temp);
        temp = "";
        refershDesTxt();
    }

    void refershDesTxt()
    {
        if (onPage < pagesList.Count - 1)
        {
            rightBtn.SetActive(true);
        }
        else
        {
            rightBtn.SetActive(false);
        }

        if (onPage > 0 && pagesList.Count != 0)
        {
            leftBtn.SetActive(true);
        }
        else
        {
            leftBtn.SetActive(false);
        }
        description.GetComponent<Text>().text = pagesList[onPage];
        Debug.Log(pagesList[onPage]);
    }

    public void nxtPage()
    {
        onPage += 1;
        refershDesTxt();
    }

    public void lstPage()
    {
        Debug.Log("Pre Onpage: " + onPage);
        onPage -= 1;
        Debug.Log("Aft Onpage: " + onPage);
        refershDesTxt();
    }

    public void returnToMainScreen()
    {
        int saveslot = PlayerPrefs.GetInt("currentGame");
        PlayerPrefs.DeleteKey("pps" + saveslot + "ttln");
        PlayerPrefs.DeleteKey("sl" + saveslot + "d");
        PlayerPrefs.DeleteKey("sl" + saveslot + "p");
        PlayerPrefs.DeleteKey("sl" + saveslot + "a");
        PlayerPrefs.DeleteKey("sl" + saveslot + "o");
        PlayerPrefs.DeleteKey("sl" + saveslot + "u");
        PlayerPrefs.DeleteKey("sl" + saveslot + "h");
        for (int i = 0; i < PlayerPrefs.GetInt("sl" + saveslot + "ev"); i++)
        {
            PlayerPrefs.DeleteKey("sl" + saveslot + "ev_l_" + i);
        }
        PlayerPrefs.DeleteKey("sl" + PlayerPrefs.GetInt("sl" + saveslot + "ev") + "ev");
        PlayerPrefs.DeleteKey("sl" + saveslot + "ev_c");
        PlayerPrefs.DeleteKey(saveslot + "_waitingEvent");
        PlayerPrefs.DeleteKey("CntEveSys_triggerDay");
        PlayerPrefs.DeleteKey("CntEveSys_line");
        fadecloth.SetActive(true);
        fadecloth.GetComponent<Animator>().Play("fadecloth-fade-out");

        
    }


}
