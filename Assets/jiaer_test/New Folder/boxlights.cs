using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxlights : MonoBehaviour
{
    public int count;
    public GameObject item;//物品
    public GameObject boxlight;//高亮物品框
    public int blick_count=0;//用于自身脚本点击记录

    private void OnMouseDown()
    {
        if (blick_count == 0)
        {
            if (item != null)
            {
                item.GetComponent<timepiece>().isjubao = true;
            }
            blick_count++;
        }
        else
        {
            if (item != null)
            {
                item.GetComponent<timepiece>().isjubao = false;
            }
            blick_count--;
        }
    }
    private void OnMouseExit()
    {
        if (blick_count == 0)
        {
            boxlight.GetComponent<Transform>().Translate(0, 0, 0.1f);
            if (item != null)
            {
                GameObject.Find("beibao/itemexper").GetComponent<TextMesh>().text = "";
                item.GetComponent<timepiece>().isjubao = false;
            }
        }
    }
    private void OnMouseEnter()
    {
        if (blick_count == 0)
        {
            boxlight.GetComponent<Transform>().Translate(0, 0, -0.1f);
            if (item != null)
            {
                string newtext = item_information(item.GetComponent<timepiece>().information);
                GameObject.Find("beibao/itemexper").GetComponent<TextMesh>().text = newtext;
            }
        }
    }
    private string item_information(string example)
    {
        string a = "\n";
        for(int i=4;i< item.GetComponent<timepiece>().information.Length+3; i+=5)
        {
            example = example.Insert(i, a);
        }
        return example;
    }

}
