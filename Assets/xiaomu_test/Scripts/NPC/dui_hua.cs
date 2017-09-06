using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dui_hua : MonoBehaviour
{

    //所有对话内容及判断条件

    public static int a = 0; //这两个变量让对话代码可以正常执行
    public static int b = 0;

    public static string npc_name;

    public static Image Dui_hua_image { set; get; } //对话框的Image
    public static Text Dui_hua_text { set; get; }

    public static Canvas Allbutton { set; get; } //一开始是隐藏button的，需要时调用出来

    public static Button Button_1 { set; get; } //3个button
    public static Button Button_2 { set; get; }
    public static Button Button_3 { set; get; }

    public static Text Button1_text { set; get; } //3个button对应的text
    public static Text Button2_text { set; get; }
    public static Text Button3_text { set; get; }


    all_dui_hua all_dh = new all_dui_hua(); //实例化all_dui_hua



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

        Allbutton = GameObject.Find("AllButton").GetComponent<Canvas>(); //以下所有button
        Allbutton.enabled = false;

        Button_1 = GameObject.Find("Button1").GetComponent<Button>();
        //Button_1.enabled = false;

        Button_2 = GameObject.Find("Button2").GetComponent<Button>();
        //Button_2.enabled = false;

        Button_3 = GameObject.Find("Button3").GetComponent<Button>();
        //Button_3.enabled = false;

        Button1_text = GameObject.Find("Button1_Text").GetComponent<Text>();
        //Button1_text.enabled = false;

        Button2_text = GameObject.Find("Button2_Text").GetComponent<Text>();
        //Button2_text.enabled = false;

        Button3_text = GameObject.Find("Button3_Text").GetComponent<Text>();
        //Button3_text.enabled = false;

    }


    void text_open() //启用text
    {
        Dui_hua_image.enabled = true;
        Dui_hua_text.enabled = true;
    }

    void text_shut() //关闭text
    {
        Dui_hua_image.enabled = false;
        Dui_hua_text.enabled = false;
    }

    void button_open() //启用button
    {
        Allbutton.enabled = true;
    }

    void button_shut()
    {
        Allbutton.enabled = false;
    }

    void all_shut()
    {
        text_shut();
        button_shut();
    }


    void dh_kuang_end() //打开点击对话框进行关闭
    {
        dh_button.dui_hua_kuang_end = true;
    }

    void dh_kuang_next() //打开点击对话框继续对话
    {
        dh_button.dui_hua_next = true;
    }




    public void npc_dui_hua()  //这里重新实现对话框
    {
        if(npc_name == "NPC1")
        {
            if (!bool_dui_hua.bool_dh[0])
            {
                text_open();

                bool_dui_hua.bool_dh[0] = true;

                Dui_hua_text.text = all_dh.dh_nr_10000;

                dh_kuang_next();

                return;
            }
            if (bool_dui_hua.bool_dh[0])
            {
                text_open();

                bool_dui_hua.bool_dh[1] = true;

                Dui_hua_text.text = all_dh.dh_nr_10001;

                dh_kuang_end();
            }


        }

        if (npc_name == "NPC2")
        {
            if (bool_dui_hua.bool_dh[1] && !bool_dui_hua.bool_dh[2])
            {
                text_open();

                bool_dui_hua.bool_dh[2] = true;

                Dui_hua_text.text = all_dh.dh_nr_10002;

                dh_kuang_end();

                return;
            }

            if (bool_dui_hua.bool_dh[2] && !bool_dui_hua.bool_dh[5])
            {
                text_open();

                button_open();

                bool_dui_hua.bool_dh[3] = true;
                bool_dui_hua.bool_dh[4] = true;
                bool_dui_hua.bool_dh[5] = true;

                Button1_text.text = all_dh.dh_nr_10003;
                Button2_text.text = all_dh.dh_nr_10004;
                Button3_text.text = all_dh.dh_nr_10005;

                Button_1.onClick.AddListener(all_shut);
                Button_2.onClick.AddListener(npc_dui_hua);
                Button_3.onClick.AddListener(npc_dui_hua);
                               
            }




        }
    }



}









