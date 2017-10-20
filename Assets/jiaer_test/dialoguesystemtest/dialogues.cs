using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using System;

public class dialogues : jiagou {
    private GameObject text;
    private List<string> dialogues_list;  
    private int dialogue_index = 0; 
    private int dialogue_count = 0;

    private string ID;
    private string NPC;
    public enum Attribute{ dia, cho }
    private Attribute att;
    private bool cantalk;
    private bool istalk;
    private string content;
    // Use this for initialization
    void Start(){
        text = GameObject.Find("Canvas/Text");
        XmlDocument xmlDocument = new XmlDocument();
        dialogues_list = new List<string>();
        string data = Resources.Load("dialoguedata").ToString();
        xmlDocument.LoadXml(data);   
        XmlNodeList xmlNodeList = xmlDocument.SelectSingleNode("game").ChildNodes;
        foreach (XmlNode xmlNode in xmlNodeList) 
        {
            XmlElement xmlElement = (XmlElement)xmlNode;    
            dialogues_list.Add(xmlElement.ChildNodes.Item(0).InnerText + "," + xmlElement.ChildNodes.Item(1).InnerText + "," + xmlElement.ChildNodes.Item(2).InnerText + "," + xmlElement.ChildNodes.Item(3).InnerText + "," + xmlElement.ChildNodes.Item(4).InnerText+","+ xmlElement.ChildNodes.Item(5).InnerText);
        }
        dialogue_count = dialogues_list.Count; 
        dialogues_handle(0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            dialogue_index++;  
            if (dialogue_index < dialogue_count) 
            {
                dialogues_handle(dialogue_index);
            }
        }
    }

    void dialogues_handle(int dialogue_index)
    {
        //切割数组  
        string[] role_detail_array = dialogues_list[dialogue_index].Split(',');//list中每一个对话格式就是“角色名,对话”  
        ID = role_detail_array[0];
        NPC = role_detail_array[1];
        att = (Attribute)Enum.Parse(typeof(Attribute), role_detail_array[2]);
        cantalk = XmlConvert.ToBoolean(role_detail_array[3]);
        istalk = XmlConvert.ToBoolean(role_detail_array[4]);
        content = role_detail_array[5];
        text.GetComponent<Text>().text = content;
    }    
}
