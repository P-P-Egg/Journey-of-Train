using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dui_hua : MonoBehaviour {

    private int yi_ci = 0; //一次性的东西

    private string dui_hua_string10001;
    public static int dui_hua_int10001;


    void Start () {
		
	}
	
	void Update () {

        dui_hua_10001();
    }



    public void duihua_neirong(int id) //根据参数引出对话内容
    {
        if(id == 10001)
        {
            dui_hua_10001();
        }        
    }

    //以下是详细的对话内容
    private void dui_hua_10001()
    {
        if (yi_ci == 0)
        {
            dui_hua_string10001 = "dui_hua1_10001";  //对话的实际内容
            npc_guanli.Dui_hua_text.text = dui_hua_string10001;

            dui_hua_int10001 = 1; //改变对话进程
            yi_ci = 1;
        }
    }



}
