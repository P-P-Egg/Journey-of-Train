using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : jiagou {
    private Vector3 testpos;
    private void Start()
    {
        testpos = GameObject.Find("Main Camera").GetComponent<Transform>().position;
    }
    private void OnMouseDown()
    {
        testpos.y += 3;
        testpos.z += 9.9f;
        GameObject.Find("dialoguebox").GetComponent<Transform>().position = testpos;
    }
}
