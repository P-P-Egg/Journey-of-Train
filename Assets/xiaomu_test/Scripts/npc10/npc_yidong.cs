﻿using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.EventSystems;

public class npc_yidong : MonoBehaviour {

    public static Vector3 dian_pos; //点击后鼠标的世界坐标
    private Vector3 screenPos; //屏幕坐标

    private Vector3 jue_se_pos; //角色自身

    public static bool chushi_ps = false; //摄像机的一个bool

    private Vector3 velocity = Vector3.zero; //没什么用的

    private float jue_se_speed = 5; //角色移动速度

    private Animator animator; //动画

    private Vector3 jue_se_sca;//角色大小

    private Vector3 jue_se_pos2;//点击时角色位置

    private Vector3 jue_se_oldpos;//上一帧角色位置

    private Vector3 jue_se_cha;//位置差


    //public float ji_shi;

    private Vector3 dian2;
    private Vector3 dian3;


    void Start () {
        
        screenPos = Camera.main.WorldToScreenPoint(transform.position);
        animator = GetComponent<Animator>();
    }
	

	void Update () {

        if (Time.timeScale != 0)
        {
            yidong();
            Animation();
        }
        else
        {
            animator.SetTrigger("zhujue_idle");
        }
        
        jue_se_sca = transform.localScale;
        jue_se_pos = transform.position;
        if (jue_se_oldpos == Vector3.zero)
        {
            //什么也不干
        }
        else
        {
            jue_se_cha = jue_se_pos - jue_se_oldpos;
        }
        jue_se_oldpos = jue_se_pos;
    }


    void Animation()
    {

        if (Input.GetMouseButtonDown(0)) //&& !EventSystem.current.IsPointerOverGameObject()) //鼠标点击位置
        {
            dian2 = Input.mousePosition;
            dian3 = Camera.main.ScreenToWorldPoint(dian2);
        }
       
        float a = System.Math.Abs(dian3.x);  //取绝对值
        float b = System.Math.Abs(transform.position.x);

        //Debug.Log(a);
        //Debug.Log(b);

        //if(a - b > 0.2f) //这里条件肯定还要改的
        //{
        //animator.SetTrigger("zhujue_right");
        //}
        //if(a - b < 0.1f)
        //{
        //animator.SetTrigger("zhujue_idle");
        //}
        if (jue_se_cha.x!=0)
        {
            animator.SetTrigger("zhujue_right");
        }
        else
        {
            animator.SetTrigger("zhujue_idle");
        }
    }

    void yidong()
    {

        if (Input.GetMouseButtonDown(0)) //&& !EventSystem.current.IsPointerOverGameObject())  //鼠标点击后，获取鼠标位置
        {

            Vector3 dianV = Input.mousePosition;
            dianV.z = screenPos.z;
           
            dian_pos = Camera.main.ScreenToWorldPoint(dianV);

            chushi_ps = true;

            jue_se_pos2 = jue_se_pos;


        }
        if (chushi_ps)  //角色移动到鼠标位置
        {
            if(dian_pos.x - transform.position.x >= 0)  //如果点击的位置大于角色位置
            {              
                transform.Translate(Vector3.right * Time.deltaTime* jue_se_speed, Space.World);
            }

            if(dian_pos.x - transform.position.x < 0) //如果点击位置小于角色位置
            {
                transform.Translate(Vector3.left * Time.deltaTime*jue_se_speed, Space.World);
            }                      
        }
        if (dian_pos.x - jue_se_pos2.x > 0 && jue_se_sca.x < 0)
        {
            Vector3 jue_se_sca2 = jue_se_sca;
            jue_se_sca2.x = -jue_se_sca2.x;
            transform.localScale = jue_se_sca2;
        }
        if (dian_pos.x - jue_se_pos2.x < 0 && jue_se_sca.x > 0)
        {
            Vector3 jue_se_sca2 = jue_se_sca;
            jue_se_sca2.x = -jue_se_sca2.x;
            transform.localScale = jue_se_sca2;
        }
    }
}
