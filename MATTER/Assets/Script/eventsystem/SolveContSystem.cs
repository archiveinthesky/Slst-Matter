using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolveContSystem : MonoBehaviour
{
    public List<string> ContEvent, EveTrue, EveFalse, re;
    public GameObject DeclineButton;
    public bool tempSaveChoice, triggeredYesterday;
    private int days;
    private int triggerDay;
    private int line;
    void Start()
    {
        //1
        ContEvent.Add("今天仍然是個適合探索的好天氣，不過森林中似乎傳來了甚麼聲音？是喪屍嗎？不對，他們的恐怖叫聲你早已習慣。今天的聲音稍微有些特別，似乎是有什麼東西墜落了，是否要去查看呢？");
        EveTrue.Add("在這種荒山野嶺，聽到這種聲音可不常見，特別是這樣的巨大聲響，在好奇心的驅使下，你決定去聲音源頭看看。走了一段時間後，你到達了目的地，聲音的源頭居然是一架印著紅色十字的墜毀直升機，為保險起見，你先躲在了一旁的樹叢中查看情況。果然不久後，兩個軍人從樹林走出，他們似乎不像那架軍用直升機的駕駛，因為他們沒有挫傷，服裝也非常整潔，這真的非常奇怪，不過現在不是思考的時候，再這樣下去他們會發現你的，要快點離開才行。");
        EveFalse.Add("");
        //2
        ContEvent.Add("繼上次發現墜毀的直升機後，你一直處於十分警戒的狀態，因為這件事存在了太多的疑點，軍用直升機為何會墜落在這種地方？那兩個軍人是從哪裡來的，難道有人駐紮在這？這些問題困擾著你，也讓你擔心自己的生命安全，是否要再去直升機墜落地點勘察呢？");
        EveTrue.Add("你從上次的路線再次到達了軍用直升機的墜落地點，幸運的是，沒有人在看守。當你走近之前的位置時，你發現原本的直升機已經不見了，地上只留下奇怪的綠色液體，當你想再靠近點觀察時，附近傳來急促的腳步聲。一名軍人模樣的人用槍口指著你，並讓你表明自己的身分，無奈之下你只好將自己是某製藥公司的研究員來尋找解藥的事告訴了軍人，他聽完拿起對講機說了些什麼，再次抬頭看向你。軍人用眼神示意讓你跟著他走，你只能照辦，走了一段路之後你們來到了軍營，它位於樹林中的一塊空地，看起來有些簡易，不過設備卻很齊全，似乎是新搭建的，你不動聲色地觀察四周，直到軍人將你引導到最大的帳篷。帳篷中坐著一個人，他似乎是那名軍人的上級，在你進入帳篷後他便開始解釋為何要你來這裡。「不久之前，喪屍大規模出現，情況完全失控了，民間….不，就連軍方組織都無法抵抗，人們不停的犧牲，最後只能將倖存者送到軍方避難所，可是他們大多受了傷，無法堅持太久，這樣的狀況真的非常糟，而我們又恰巧聽聞這片樹林中有著具有極大療效的藥草，後面的事你應該就明白了。」「我們需要你的幫助。」聽到這些訊息的你感到萬分震驚和悲傷，研發解藥固然重要，可是眼前的軍官迫切需要你的幫助，究竟應該怎麼辦呢？軍官看出了你的猶豫，讓你先回家思考一會兒再給他答案。");
        EveFalse.Add("你認為關心這種事情毫無意義，畢竟解藥找到後就能離開了，不是嗎？ ");
        //3
        ContEvent.Add("上次那名軍官向你求助的事，你思考了很久，你知道找到解藥是解決一切問題根源的方法，不過現在有一群人正在避難所裡等待救助，雖然這讓你十分為難，不過最終你還是下定決心。是否幫助那名軍官援助避難所裡的人？");
        EveTrue.Add("你認為現在最應該做的是幫助避難所中的人，下定決心後你決定幾天後去軍營找那名軍官商討。");
        EveFalse.Add("在某種角度而言，你面臨了一個兩難的抉擇，幫助人們固然重要，不過若要解決一切你仍然得研發出解藥，畢竟這是最「保險」的方式了。");
        //4
        ContEvent.Add("你前去拜訪那名需要幫助的軍官，他十分高興你的到來，並熱情的招待你，在經過一番寒暄後，他突然端正了態度，再次詢問你是否願意幫助避難所中的人。是否答應軍官的請求？");
        EveTrue.Add("聽到你的肯定後，他露出了一抹笑容，似乎是很高興？不論如何你和他開始討論詳細內容。「要治療避難所中的大量患者，必須用一種名為【返魂香】的植物提煉油，稀釋後製做成傷藥使用」聽完軍官的話後你似乎想到了些什麼，你在樹林中探索的時間不少，說到【返魂香】你說不定會有，不過還是得找找看就是了。承諾軍官尋找【返魂香】後，你就準備回基地去了，不過路上你一直有種怪異的感覺，像是什麼在凝視著你，想到這你也發現最近喪屍莫名變多了，這究竟是為什麼呢？");
        EveFalse.Add("軍官聽到你的答覆後面色並沒有什麼改變，只是你依然感受到他有些失落。告別了軍官後，你在回到基地的路上繼續搜索物資，不過走著就感到後頸被敲擊而失去了意識。你從昏迷中醒來，眼前一片悠藍，神智恢復後的你，發現自己被關在類似實驗槽的地方，想大聲呼救卻發現自己只能不斷的吐出泡沫，想要掙扎卻因身上扎滿了怵目驚心的管子而動彈不得，你就在這樣的狀況下再次失去了意識。"); // end id --
        //5
        ContEvent.Add("經過長時間的努力後，你終於找到了【返魂香】，你興高采烈地去找軍官報告成果。到了軍營之後，你發現軍人們今天特別【警戒】，是發生了什麼事嗎？雖然好奇，不過你知道當務之急是將【返魂香】交給軍官。看到成果的軍官非常高興，並邀請你前往避難所觀看藥物提煉的過程，是否答應？");
        EveTrue.Add("軍官邀請你搭乘直升機前往避難所，值得注意的是軍用直升機上的徽章和你之前看到的那架墜落直升機不太相同，若之前的是代表救濟的紅色十字，那麼這架直升機就是六芒星，為什麼不同呢？你來不及思考太多，直升機已經抵達了【避難所】，看著眼前巨大的建築，你心中突然有一些不好的預感。金屬門緩緩地打開，你看到數以萬計的民眾蜷縮在角落顫抖，那樣的眼神並不是像在看著救世主，恐懼、害怕、退縮，彷彿眼前的軍官是比喪屍更加可怕的【惡魔】，想到這裡你不禁向後「為什麼要害怕呢？我明明是在救贖你們，你說是吧？」前方的軍官突然回頭看向你，他眼中閃爍的是【狂熱】。你當機立斷的向後逃走，不過已經來不及了，軍官命人將你捉住，並將你帶到了更深處的區域。你們來到像是實驗室的地方，裡面有許多穿著白色衣服的人員正在工作，而中心擺放著大量盛滿水的實驗槽，看到其中的景像你忍不住乾嘔，槽中擺放的東西是人。具體來說，是已經快被分解成肉塊的人。「怎麼樣？很棒吧？這些是我新世界的子民們哦，多麼美麗而又純潔的生物們呀!」你忍住一陣噁心感，詢問軍官的真實目的。「目的，救贖這醜惡的世界算不算，我知道的，你是想知道我的作法對吧？那麼我就從頭說起了，政府的工作是保護人民的權益，而我們這些士兵們當然也不例外，不過以我看來這是個愚昧的行為，人們根本不配的到幫助，幸好我的主給了指引，【創造新世界】，這不是很棒嗎？一切的起點就從這裡開始。」聽他說的話後你感到震驚，過去的種種此時連成了一線，公司的藥物問題、搜索中撿到的軍事資源、墜落的直升機、綠色的液體、返魂香、實驗體，他和公司合力不斷研發出延遲發作的病毒，誘導人們病毒具傳染性，將收容的人拿來進行實驗，當軍方靠近基地時就將他們秘密處理，掉落的物資也是，墜落的直昇機也是，他們不斷的投放喪屍，並研發新的生化武器，打算加速人類滅亡的速度，而【返魂香】無疑是病毒的解藥，而你卻將最後的希望交到了敵人手中。「看你的表情，我想你應該明白了，製藥公司什麼的從來就是個陰謀，我等待這一刻非常久了，現在就讓你看看我的最終成果吧!可憐的實驗品」"); // end id --
        EveFalse.Add("「這可由不得你」軍官命令一旁的士兵將你扣上直升機，你很害怕，不過也無法抵抗，終於飛行到達了目的地，你猛力的開始掙扎，幾位軍人一時不察鬆開了你，你快速的將他們手中拿著的【返魂香】搶走，並且頭也不回的跑走了，但你並沒有注意到身後的軍官臉上那一抹詭異的笑容。跑了很久以後，你慢慢累得停了下來，當你鬆了口氣，以為擺脫了追兵時，突然聽見身後一陣巨響，視線逐漸被染紅，意識逐漸模糊，在閉上眼睛的前一刻，你似乎看到那位軍官緩緩向你走來。(死亡)");


        //6
        ContEvent.Add("經過了長時間的研究後，你對解藥的研發終於有了實質上的進展，至少你確定它一定是這座森林中的稀有植物，叫做返魂香，誰會想到小小一片的它竟然是如此珍貴的東西呢?");
        EveTrue.Add("自從你確認了解藥原料的名稱後，你更加積極地進行研究了，只要把返魂香的汁液處理好，那一切就沒問題了");
        EveFalse.Add("自從你確認了解藥原料的名稱後，你更加積極地進行研究了，只要把返魂香的汁液處理好，那一切就沒問題了");// no false

        //7(返魂香)
        ContEvent.Add("在經過長久的實驗後，你終於用返魂香的提煉精油混合其他物質製成了解藥，好消息總是令人開心的，不過要怎麼將完成的解藥投放到感染區呢?真令人傷腦筋呢......");
        EveTrue.Add("");
        EveFalse.Add("");
        //8 (2 day after)
        ContEvent.Add("前幾日你在樹林間遇見了一群士兵，他們原本對你十分戒備，不過當你表明了自己的身分，以及說了需要投放解藥這件事後，他們態度突然變得和善，並且十分願意幫助你，雖然有些奇怪的違和感，不過知道了軍人們願意主動協助這個好消息後，你也沒在意那麼多");
        EveTrue.Add("");
        EveFalse.Add("");
        //9(1 day after)
        ContEvent.Add("你將解藥交到了軍人手上，他們承諾你一定會成功投放解藥。令人開心的是，他們做到了，在你接獲的資訊中提到，變成喪屍的人們正在恢復，這真的令人十分感動");
        EveTrue.Add("");
        EveFalse.Add("");
        //10(1 day after)
        ContEvent.Add("時間過了很久，人們已經開始修復在災難中變得破敗的城市，這樣的日子真的很棒，一切貌似正在回到以往的輝煌。正當你以為一切正在好轉時，異變突然發生，進行重建工作的人們開始發狂，身上長出了奇怪的肉塊，看似再次變成了喪屍，更加壯碩、強大，更具毀滅性，這一次已經無法阻止了，看著悲劇再次重演的你明白了前因後果，想起了那日的軍人們【他們的臂章不是一般的紅十字軍徽，而是六芒星】。在死亡來臨的前一刻，你多麼希望能倒回分歧的那一刻，就算沒有能力拯救世界，但至少也要知道事情的真相，讓自己能夠死得瞑目。");
        EveTrue.Add(""); // end
        EveFalse.Add("");

        line = PlayerPrefs.GetInt("CntEveSys_line");
        triggerDay = PlayerPrefs.GetInt("CntEveSys_triggerDay");

    }

    public void newday(int daycounter)
    {
        if (checkOverrideEvent())
        {
            applyChoice(tempSaveChoice);
        }
        PlayerPrefs.SetInt("CntEveSys_triggerDay", triggerDay);
        PlayerPrefs.SetInt("CntEveSys_line", line);
        days = daycounter;
    }

    public bool checkOverrideEvent()
    {
        switch (line)
        {
            case 0:
                if (days >= triggerDay)
                {
                    return true;
                }
                break;
            case 1:
                if (days >= triggerDay)
                {
                    return true;
                }
                break;
            case 2:
                if (days >= triggerDay)
                {
                    return true;
                }
                break;
            case 3:
                if (days >= triggerDay)
                {
                    return true;
                }
                break;
            case 4:
                if (days >= triggerDay /* +返魂香 */ )
                {
                    return true;
                }
                break;

            case 6:
                if (days >= triggerDay)
                {
                    Debug.Log("Line 6 triggered");
                    return true;
                }
                break;

            case 7:
                if (days >= triggerDay /* +返魂香 */)
                {
                    return true;
                }
                break;
            case 8:
                if (days >= triggerDay)
                {
                    return true;
                }
                break;
            case 9:
                if (days >= triggerDay)
                {
                    return true;
                }
                break;
            case 10:
                if (days >= triggerDay)
                {
                    return true;
                }
                break;
            
            case 11:
                if (days >= triggerDay)
                {
                    return true;
                }
                break;

        }
        return false;
    }

    public List<string> getTodaysEvent()
    {
        re.Clear();
        switch (line)
        {
            case 0:
                re.Add(ContEvent[0]);
                re.Add(EveTrue[0]);
                re.Add(EveFalse[0]);
                break;

            case 1:
                re.Add(ContEvent[1]);
                re.Add(EveTrue[1]);
                re.Add(EveFalse[1]);
                break;

            case 2:
                re.Add(ContEvent[2]);
                re.Add(EveTrue[2]);
                re.Add(EveFalse[2]);
                break;

            case 3:
                re.Add(ContEvent[3]);
                re.Add(EveTrue[3]);
                re.Add(EveFalse[3]);
                break;
            case 4:
                re.Add(ContEvent[4]);
                re.Add(EveTrue[4]);
                re.Add(EveFalse[4]);
                break;
            case 5:
                PlayerPrefs.SetInt("endgameId", 1);
                break;
            case 6:
                PlayerPrefs.SetInt("endgameId", 2);
                break;
            case 7:
                PlayerPrefs.SetInt("endgameId", 3);
                break;
            case 8:
                re.Add(ContEvent[5]);
                re.Add(EveTrue[5]);
                re.Add(EveFalse[5]);
                DeclineButton.GetComponent<Button>().interactable = false;
                break;
            case 9:
                re.Add(ContEvent[6]);
                re.Add(EveTrue[6]);
                re.Add(EveFalse[6]);
                DeclineButton.GetComponent<Button>().interactable = false;
                break;
            case 10:
                re.Add(ContEvent[7]);
                re.Add(EveTrue[7]);
                re.Add(EveFalse[7]);
                DeclineButton.GetComponent<Button>().interactable = false;
                break;
            case 11:
                Debug.Log("Entering case 11");
                re.Add(ContEvent[8]);
                re.Add(EveTrue[8]);
                re.Add(EveFalse[8]);
                DeclineButton.GetComponent<Button>().interactable = false;
                PlayerPrefs.SetInt("endgameId", 4);
                break;
            case 12:
                re.Add(ContEvent[9]);
                re.Add(EveTrue[9]);
                re.Add(EveFalse[9]);
                DeclineButton.GetComponent<Button>().interactable = false;
                break;
                //end                

        }

        return re;
    }



    public void applyChoice(bool choice)
    {
        triggeredYesterday = checkOverrideEvent();
        if (choice)
        {
            switch (line)
            {
                case 0:
                    line = 1;
                    triggerDay = days + Random.Range(2, 4);
                    break;
                case 1:
                    line = 2;
                    triggerDay = days + Random.Range(2, 4);
                    break;
                case 2:
                    line = 3;
                    triggerDay = days + Random.Range(2, 4);
                    break;
                case 3:
                    line = 4;
                    triggerDay = days + Random.Range(2, 4);
                    break;
                case 4:
                    line = 6;
                    PlayerPrefs.SetInt("endgameId", 2);
                    Debug.Log("Set endgameId to: " + PlayerPrefs.GetInt("endgameId"));
                    break;

                case 8:
                    line = 9;
                    DeclineButton.GetComponent<Button>().interactable = true;
                    triggerDay = days + Random.Range(2, 4);
                    break;
                case 9:
                    line = 10;
                    DeclineButton.GetComponent<Button>().interactable = true;
                    triggerDay = days + Random.Range(2, 4);
                    break;
                case 10:
                    line = 11;
                    triggerDay = days + Random.Range(2, 4);
                    Debug.Log("Triggered Case 10: " + triggerDay);
                    DeclineButton.GetComponent<Button>().interactable = true;
                    break;
                case 11:
                    line = 12;
                    triggerDay = days + Random.Range(2, 4);
                    DeclineButton.GetComponent<Button>().interactable = true;
                    break;
                
                case 12:
                    line = 12;
                    PlayerPrefs.SetInt("endgameId", 4);
                    Debug.Log("Set endgameId to: " + PlayerPrefs.GetInt("endgameId"));
                    break;

            }
        }
        else
        {
            switch (line)
            {
                case 0:
                    line = 8;
                    triggerDay = days + Random.Range(3, 5);
                    break;
                case 1:
                    line = 8;
                    triggerDay = days + Random.Range(2, 4);
                    break;
                case 2:
                    line = 8;
                    triggerDay = days + Random.Range(2, 4);
                    break;
                case 3:
                    line = 5;
                    PlayerPrefs.SetInt("endgameId", 1);
                    Debug.Log("Set endgameId to: " + PlayerPrefs.GetInt("endgameId"));
                    triggerDay = days +1;
                    break;
                //end
                case 4:
                    line = 7;
                    PlayerPrefs.SetInt("endgameId", 3);
                    Debug.Log("Set endgameId to: " + PlayerPrefs.GetInt("endgameId"));
                    triggerDay = days + 1;
                    break;
                    //end

                
            }
        }
    }

}
