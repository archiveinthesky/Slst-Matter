using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGenerator : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(main_thread());
    }

    IEnumerator main_thread()
    {
        GameObject target = Instantiate(item);
        float x = Random.Range(-8.3f, 7.0f);
        float y = Random.Range(-4.5f, 4.5f);
        target.transform.position = new Vector3(x, y, -2);
        target.SetActive(true);
        yield return new WaitForSeconds(Random.Range(1, 3)); 
        StartCoroutine(main_thread());
    }
}