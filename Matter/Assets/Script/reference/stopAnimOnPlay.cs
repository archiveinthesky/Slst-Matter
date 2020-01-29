using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopAnimOnPlay : MonoBehaviour
{

    public Animator targetanim;

    void Awake()
    {
        Debug.Log("called");
        targetanim.StopPlayback();
    }
}
