using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bao_zhi : MonoBehaviour {
    public Transform zhu_jue;

    private bool dian_ji;  //点击自己后

    private float zhu_jue_x;

    private float ju_li_x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ju_li();


        if (dian_ji && ju_li_x <= 3.5f)
        {
            kao_jin();

            //对话时间暂停 附带角色不能移动
            manager.talk1_bool_js = false;
            manager2.talk2_bool_js = false;
            zhujue_yidong.zhu_jue_dong = false;

            dian_ji = false;
        }

        


	}

    void ju_li() //判断距离
    {
       
        ju_li_x = Vector3.Distance(zhu_jue.position, transform.position); 
    }

    void OnMouseDown()
    {
        
        zhujue_yidong.zhu_jue_dong = true;
        dian_ji = true;
        
        
    }

    void kao_jin()
    {
        mu_1.mu_1_bool = true;
        bao_zhi_animator.bao_zhi_animator_bool = true;
    }
}
