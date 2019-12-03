/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fadeIn;
using fadeout;

public class dajunctrl : MonoBehaviour
{
    fadeIn IN;
    fadeout OUT;
    public enum stat
    {
        idle,
        i, 
        o
    };
    stat S;
    // Start is called before the first frame update

    void Start()
    {
        S = stat.idle;
    }

    // Update is called once per frame
    void Update()
    {
        if (S == stat.o)
        {
            S = stat.idle;
            IN.fadell();
        }
    }
}
*/