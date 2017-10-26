using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastjiantou : MonoBehaviour {
    private int count;
    private void Update()
    {
        count = GameObject.Find("jubaoscripts").GetComponent<jubaoscripts>().recodecount;
    }
    private void OnMouseDown()
    {
        GameObject.Find("Main Camera/jubao/New Text").GetComponent<TextMesh>().text = GameObject.Find("jubaoscripts").GetComponent<jubaoscripts>().textrecode[count - 1].GetComponent<TextMesh>().text;
        print(GameObject.Find("Main Camera/jubao/New Text").GetComponent<TextMesh>().text);
        print(GameObject.Find("jubaoscripts").GetComponent<jubaoscripts>().textrecode[count - 1].GetComponent<TextMesh>().text);
        print("hehe");
    }
}
