﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcattribute : MonoBehaviour {
    public Transform z_j_pos; //主角的位置

    public GameObject backpack;
    public int money;

    private bool dian_ji;  //点击自己后
    private float ju_li_x;// 主角的位置

    void Start()
    {
     

    }

    void Update()
    {
        ju_li();

       if (dian_ji && ju_li_x <= 3)
        {
            mu_2.mu_2_bool = true; //黑幕2显示出来


            backpack.SetActive(true);
            Vector3 newposition = GameObject.FindWithTag("MainCamera").transform.position;
            backpack.transform.position = new Vector3(newposition.x, newposition.y, -4.1f);

            //对话时间暂停 附带角色不能移动
            manager.talk1_bool_js = true;
            manager2.talk2_bool_js = true;



            //Time.timeScale = 0;

            dian_ji = false;
        }
        
    }

    
    private void OnMouseDown()
    {
        dian_ji = true;      
    }


    void ju_li()//判断距离
    {
        //主角的位置

        ju_li_x = Vector3.Distance(z_j_pos.position, transform.position);
    }
        
}
