using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class npc_guanli : MonoBehaviour {

    public int Qian { set; get; } //经济状况 
    public Vector3 Pos { set; get; } //NPC自身位置 

    public static Image Dui_hua_image { set; get; } //对话框的Image
    public static Text Dui_hua_text { set; get; } //对话框的Text 注意是静态

    void Awake()
    {
        chu_shi_hua();
    }


    void Start() {


    }

    void Update() {
        

    }

    void chu_shi_hua()//初始化游戏
    {
        Dui_hua_image = GameObject.Find("dui_hua_Image").GetComponent<Image>();
        Dui_hua_image.enabled = false; //不启用

        Dui_hua_text = GameObject.Find("dui_hua_Text").GetComponent<Text>();
        Dui_hua_text.enabled = false; //不启用

    }

    void text_qiyong() //启用text
    {
        Dui_hua_image.enabled = true;
        Dui_hua_text.enabled = true;
    }


    void OnMouseDown() //当鼠标对NPC按下左键时,返回true
    {
        Pos = gameObject.transform.position; // 获取NPC的位置,这是为了让主角靠近NPC

        //Dui_hua_image.enabled = true; //启用
        //Dui_hua_text.enabled = true; //启用
        dui_hua_kuang();
    }

    public void dui_hua_kuang() //判断弹出对话框
    {

        /*dui_hua duihua = new dui_hua();*/ //以下为实验，成功
        if (/*Dui_hua_text.enabled && */dui_hua.dui_hua_int10001 == 1) //所有判断手动调整，根据判断给出台词
        {
            text_qiyong(); //这一段出问题了，回家修改
            dui_hua duihua = new dui_hua();
            duihua.duihua_neirong(10001);
        }
    }
}

