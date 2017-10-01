using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Collections.Generic;

public class dialogues1 : jiagou {
    private GameObject text;
    private GameObject npc;
    private List<string> dialogues_list;
    private int dialogue_index = 0;
    private int dialogue_count = 0;
    private string ID;
    private string NPC;
    private bool cantalk;
    private bool istalk;
    private string content;
    private void Start()
    {
        text = GameObject.Find("Canvas/Text");
        npc = GameObject.Find("Canvas/npc");
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
    }
    private void OnMouseDown()
    {
        
    }
}
