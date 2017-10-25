using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zong_liang : MonoBehaviour {


    public static int npc_box_int; //点击NPC背包显示第几个背包
    public static string wu_ping_miao_su; //物品的描述
    public static string miao_su_zhuan;
    public static string box_name;

    void Start () {
		
	}
	
	
	void Update () {
        if (wu_ping_miao_su == null)
        {
            wu_ping_miao_su = "无描述";
        }
        miao_su_zhuan = item_information(wu_ping_miao_su);
       

    }

    private string item_information(string example)
    {
        string a = "\n";    
        for (int i = 10; i < wu_ping_miao_su.Length; i += 11)
        {
            example = example.Insert(i, a);
        }
        return example;
    }
}
