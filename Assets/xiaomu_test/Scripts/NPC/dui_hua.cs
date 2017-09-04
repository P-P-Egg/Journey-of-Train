using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dui_hua : MonoBehaviour {

    public int yi_ci = 0; //一次性的东西

    private string dui_hua_string10001; 
    public static int dui_hua_int10001 = 0;

    public static int button_int10002 = 0;


    void Start () {
		
	}
	
	void Update () {

        //dui_hua_10001();
    }



    public void duihua_neirong(int id) //根据参数引出对话内容
    {
        if(id == 10001)
        {
            dui_hua_10001();
        }        
    }


    public void button_neirong(int id) //储存所有的button内容
    {
        if(id == 10002)
        {
            button_10002();
        }
    }


    //以下是详细的对话内容
    private void dui_hua_10001()
    {
        if (yi_ci == 0) //第一个对话显示条件
        {
            dui_hua_string10001 = "dui_hua1_10001";  //对话的实际内容
            npc_guanli.Dui_hua_text.text = dui_hua_string10001;

            dui_hua_int10001 = 1; //改变对话进程
            yi_ci = 1;
        }
    }

    private void button_10002()
    {
       
        all_button.Allbutton.enabled = true;

        //button_int10002 = 1;

                
    }




}
