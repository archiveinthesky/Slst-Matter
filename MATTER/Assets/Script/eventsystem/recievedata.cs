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
        char p = '\u0070';
        char a = '\u0061';
        char o = '\u006f';
        char u = '\u0075';
        char h = '\u0068';
        char sep = '\u002c';
        char add = '\u002b';
        char min = '\u002d';

        for (int i = 0; i < changes.Length; i++)
        {
            if (changes[i] == p)
            {
                i++;
                if (changes[i] == add)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("p", GetComponent<lifeData>().getVal("p") + editval);
                    i++;
                }
                if (changes[i] == min)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("p", GetComponent<lifeData>().getVal("p") - editval);
                    i++;
                }
            }
            else if (changes[i] == a)
            {
                i++;
                if (changes[i] == add)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("a", GetComponent<lifeData>().getVal("a") + editval);
                    i++;
                }
                if (changes[i] == min)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("a", GetComponent<lifeData>().getVal("a") - editval);
                    i++;
                }
            }
            else if (changes[i] == o)
            {
                i++;
                if (changes[i] == add)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                        i++;
                    }
                    GetComponent<lifeData>().setVal("o", GetComponent<lifeData>().getVal("o") + editval);
                    i++;
                }
                if (changes[i] == min)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("o", GetComponent<lifeData>().getVal("o") - editval);
                    i++;
                }
            }
            else if (changes[i] == u)
            {
                i++;
                if (changes[i] == add)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("u", GetComponent<lifeData>().getVal("u") + editval);
                    i++;
                }
                if (changes[i] == min)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("u", GetComponent<lifeData>().getVal("u") + editval);
                    i++;
                }
            }
            else if (changes[i] == h)
            {
                i++;
                if (changes[i] == add)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("h", GetComponent<lifeData>().getVal("h") + editval);
                    i++;
                }
                if (changes[i] == min)
                {
                    i++;
                    int editval = 0;
                    while (changes[i] != sep)
                    {
                        editval *= 10;
                        editval += int.Parse(changes[i].ToString());
                    }
                    GetComponent<lifeData>().setVal("h", GetComponent<lifeData>().getVal("h") + editval);
                    i++;
                }
            }
        }
    }
}
