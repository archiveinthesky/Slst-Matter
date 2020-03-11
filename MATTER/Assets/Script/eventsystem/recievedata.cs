using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recievedata : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void applyEffect(string changes)
    {
        for (int i = 0; i < changes.Length; i++)
        {
            string edititem = changes[i].ToString();
            i++;
            int times;
            if (changes[i].ToString() == "+"){
                times = 1;
            }else{
                times = -1;
            }
            i++;
            int editval = 0;
            while (changes[i].ToString() != ","){
                editval *= 10;
                editval += int.Parse(changes[i].ToString());
                i++;
            }
            GetComponent<lifeData>().setVal(edititem, GetComponent<lifeData>().getVal(edititem) + editval * times);
        }
    }

}
