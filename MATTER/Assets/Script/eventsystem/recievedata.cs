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

    void applyEffect(string changes)
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
                    //hp + value
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
                    //hp - value
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
                    //waterStorage + value
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
                    //waterStorage - value
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
                    }
                    //foodStorage + value
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
                    //foodStorage - value
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
                    //hunger + value
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
                    //hunger - value
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
                    //thirst + value
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
                    //thurst - value
                    i++;
                }
            }
        }
    }
}
