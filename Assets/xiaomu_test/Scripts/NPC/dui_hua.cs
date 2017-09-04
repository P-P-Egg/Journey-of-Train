using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dui_hua : MonoBehaviour {

    public static int a = 0; //这两个变量让对话代码可以正常执行
    public static int b = 0;

    public static Image Dui_hua_image { set; get; } //对话框的Image
    public static Text Dui_hua_text { set; get; }

    all_dui_hua all_dh = new all_dui_hua(); //实例化all_dui_hua

    npc_guanli npc_gl = new npc_guanli();//实例化npc_guanli

    void Awake()
    {
        chu_shi_hua();
    }


    void Start()
    {


    }

    void Update()
    {


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

    public void dui_hua_kuang()
    {
        if (!bool_dui_hua.kai_guan_dui_hua[0] && npc_gl.npcName == "NPC2" && a > b)
        {
            b = a;
            text_qiyong();
            bool_dui_hua.dh_bool_10000();
            Dui_hua_text.text = all_dh.dh_nr_10000;
        }

        if (bool_dui_hua.kai_guan_dui_hua[0] && npc_gl.npcName == "NPC2" && a > b)
        {
            b = a;
            text_qiyong();
            bool_dui_hua.dh_bool_10001();
            Dui_hua_text.text = all_dh.dh_nr_10001;
        }
    }
                
    }





