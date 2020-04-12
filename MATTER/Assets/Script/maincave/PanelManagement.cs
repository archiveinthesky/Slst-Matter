using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManagement : MonoBehaviour
{
    public ObjectManagement om;
    //object panel
    public GameObject panelMother, dpObject, objName, objDescription, objApply;
    public List<Sprite> textures;
    private int inid;



    public void enterObjectDes(int id)
    {
        Debug.Log("called");
        var txts = om.recieveObjectData(id);
        objName.GetComponent<Text>().text = txts[0];
        objDescription.GetComponent<Text>().text = txts[1];
        objApply.GetComponent<Text>().text = txts[2];
        dpObject.GetComponent<Image>().sprite = textures[id];
        inid = id;
        var campos = Camera.main.transform.position;
        campos.z = 0;
        panelMother.transform.position = campos;
        panelMother.SetActive(true);
        panelMother.GetComponent<Animator>().Play("panel-zoom-in");
    }

    public void exitObjectDes()
    {
        panelMother.GetComponent<Animator>().Play("panel-zoom-out");
        inid = -1;
    }

    public void applyItem()
    {
        om.ItemUsed(inid);
        exitObjectDes();
    }


}
