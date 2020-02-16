using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunk_prefab_script : MonoBehaviour
{
    public List<Sprite> prefabs = new List<Sprite>();
    public int chunk_index;
    void Start()
    {
        GetComponentInParent<SpriteRenderer>().sprite = prefabs[chunk_index - 1];
    }
}
