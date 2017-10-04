using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;

public class dialogues1 : jiagou {
    private GameObject text;
    private List<string> dialogues_list;
    private int dialogue_index = 0;
    private int dialogue_count = 0;
    private string ID;
    private string NPC;
    private bool cantalk;
    private bool istalk;
    private string content;
    private float time;
    private void Start()
    {
        text = GameObject.Find("Canvas/Text");
        XmlDocument xmlDocument = new XmlDocument();
        dialogues_list = new List<string>();
        string data = Resources.Load("dialoguedata").ToString();
        xmlDocument.LoadXml(data);
        XmlNodeList xmlNodeList = xmlDocument.SelectSingleNode("game").ChildNodes;
        foreach (XmlNode xmlNode in xmlNodeList)
        {
            XmlElement xmlElement = (XmlElement)xmlNode;
            dialogues_list.Add(xmlElement.ChildNodes.Item(0).InnerText + "," + xmlElement.ChildNodes.Item(1).InnerText + "," + xmlElement.ChildNodes.Item(2).InnerText + "," + xmlElement.ChildNodes.Item(3).InnerText + "," + xmlElement.ChildNodes.Item(4).InnerText);
        }
        dialogue_count = 3;
    }
    private void OnMouseDown()
    {
        dialogues_loading();
    }

    private void dialogues_loading()
    {
        dialogues_handle();
    }

    private void dialogues_handle()
    {
        string[] role_detail_array = dialogues_list[dialogue_index].Split(',');//list中每一个对话格式就是“角色名,对话”  
        ID = role_detail_array[0];
        NPC = role_detail_array[1];
        cantalk = XmlConvert.ToBoolean(role_detail_array[2]);
        istalk = XmlConvert.ToBoolean(role_detail_array[3]);
        content = role_detail_array[4];
        text.GetComponent<Text>().text += content+"\n";
        dialogue_index++;
        this.GetComponent<BoxCollider>().center = new Vector3(4.2f, -2.4f, 0);
        this.GetComponent<BoxCollider>().size = new Vector3(17.75f, 4.9f,0);
    }
}
