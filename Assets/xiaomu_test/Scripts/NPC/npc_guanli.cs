﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class npc_guanli : MonoBehaviour
{

    public int Qian { set; get; } //经济状况 
    public Vector3 Pos { set; get; } //NPC自身位置     

    public string npcName; //取得自身名字

    public static bool chong_fu_dui_hua = true; //该NPC被鼠标点击后重复说的话

    public static bool npc_open = true;

    dui_hua duihua = new dui_hua();


    void Awake()
    {
        
    }


    void Start()
    {
        npcName = gameObject.transform.name;


    }

    void Update()
    {


    }


    void OnMouseDown() //当鼠标对NPC按下左键时,返回true
    {

        dui_hua.a++;
        dui_hua.npc_name = npcName;

        Pos = gameObject.transform.position; // 获取NPC的位置,这是为了让主角靠近NPC

        duihua.npc_dui_hua();      //进行对话
        
 

        if (chong_fu_dui_hua)
        {

        }

    }


}

