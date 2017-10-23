using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;

public class liechezhangdia : dialogue_jiagou {
    private  dialogue_struct[] liechezhang=new dialogue_struct[8];
    private int touch = 0;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < 8; i++)
        {
            string[] role_detail_array = dialogues_list[i].Split(',');
            liechezhang[i].ID = XmlConvert.ToInt32(role_detail_array[0]);
            liechezhang[i].ischoose = XmlConvert.ToBoolean(role_detail_array[1]);
            liechezhang[i].npc = role_detail_array[2];
            liechezhang[i].cantalk = XmlConvert.ToBoolean(role_detail_array[3]);
            liechezhang[i].istalk = XmlConvert.ToBoolean(role_detail_array[4]);
            liechezhang[i].report = XmlConvert.ToBoolean(role_detail_array[5]);
            liechezhang[i].content = role_detail_array[6];
        }
	}

    private void OnMouseDown()
    {
        if (liechezhang[touch].ischoose == false)
        {
            GameObject.FindWithTag("dialogue").GetComponent<Text>().text = liechezhang[touch].content;
            print(liechezhang[touch].content);
        }
        touch++;
    }


}
