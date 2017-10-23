using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class dialogue_jiagou : MonoBehaviour {

    private GameObject text;
    public List<string> dialogues_list;
    private int dialogue_index = 0;
    private int dialogue_count = 0;

    // Use this for initialization
    void Awake()
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
            dialogues_list.Add(xmlElement.ChildNodes.Item(0).InnerText + "," + xmlElement.ChildNodes.Item(1).InnerText + "," + xmlElement.ChildNodes.Item(2).InnerText + "," + xmlElement.ChildNodes.Item(3).InnerText + "," + xmlElement.ChildNodes.Item(4).InnerText + "," + xmlElement.ChildNodes.Item(5).InnerText+"," + xmlElement.ChildNodes.Item(6).InnerText);
        }
        dialogue_count = dialogues_list.Count;
    }

    public struct dialogue_struct {
        public int ID;
        public bool ischoose;
        public string npc;
        public bool cantalk;
        public bool istalk;
        public bool report;
        public string content;
    }
}
