using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCCcontroller : MonoBehaviour 
{
	public string cc = "";
	public bool preped = false;
	public Canvas CANVAS;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (preped)
		{
			printCC();
		}
	}

	void printCC()
	{
		// preped = false;
		Text TEXT = CANVAS.GetComponentInChildren<Text>();
		TEXT.GetComponent<Text>().text = cc;
	}
}
