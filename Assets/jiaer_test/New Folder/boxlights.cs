using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxlights : scriptstest {
    public int count;
    public GameObject go;
    // Use this for initialization
    private void OnMouseEnter()
    {
        boxlights[count].GetComponent<Transform>().Translate(0, 0, -0.1f);
        string newtext = item_information(go.GetComponent<timepiece>().information);
        GameObject.Find("back/itemexper").GetComponent<TextMesh>().text = newtext;
    }
    private void OnMouseExit()
    {
        boxlights[count].GetComponent<Transform>().Translate(0, 0, 0.1f);
        GameObject.Find("back/itemexper").GetComponent<TextMesh>().text = "";
    }
    private string item_information(string example)
    {
        string a = "\n";
        for(int i=4;i< go.GetComponent<timepiece>().information.Length+4; i+=5)
        {
            example = example.Insert(i, a);
        }
        return example;
    }

}
