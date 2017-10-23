using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test2 : jiagou {
    public Color origin = new Color();
    private void Start()
    {
        origin = GameObject.Find("Canvas/Text").GetComponent<Text>().color;
    }
    private void OnMouseEnter()
    {
        GameObject.Find("Canvas/Text").GetComponent<Text>().color = Color.red;
    }

    private void OnMouseExit()
    {
        GameObject.Find("Canvas/Text").GetComponent<Text>().color = origin;
    }

}
