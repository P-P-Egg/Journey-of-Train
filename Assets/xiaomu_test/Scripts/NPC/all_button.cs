using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class all_button : MonoBehaviour {

    public static Button Button_1 { set; get; }
    public static Button Button_2 { set; get; }
    public static Button Button_3 { set; get; }

    public static Text Button1_text { set; get; }
    public static Text Button2_text { set; get; }
    public static Text Button3_text { set; get; }

    public static Canvas Allbutton { set; get; } //一开始是隐藏button的，需要时调用出来

    void Awake()
    {
        chu_shi_hua();
    }


    void Start () {
		
	}
	

	void Update () {
		
	}

    void chu_shi_hua() //初始化
    {
        Allbutton = GameObject.Find("AllButton").GetComponent<Canvas>();
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

}
