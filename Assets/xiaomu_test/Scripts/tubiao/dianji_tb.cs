using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class dianji_tb : MonoBehaviour {

    public static bool name_xiao_hui = false; //销毁

    private Vector2 ui_weizhi; //自身UI的位置

    public RuntimeAnimatorController name_controller; //物体动画


    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        ui_weizhi = gameObject.transform.position;


        Dong_hua();
        Other_xiao_hui();

    }

    void Dong_hua()
    {

        if (cai_bei_c.value_js >= 1)
        {
            gameObject.GetComponent<Animator>().runtimeAnimatorController = name_controller;
        }

    }

     
    void OnMouseDown()  //点击后销毁
    {
        if(cai_bei_c.value_js >= 1)
        {
            name_xiao_hui = true;
            //Destroy(go);
        }
    }

    void Other_xiao_hui() //其它的销毁方式
    {
        if(cai_bei_c.value_js >= 1 && ui_weizhi.x - newnpc.npc_weizhi.x < 1)
        {
            name_xiao_hui = true;
        }
    }

}
