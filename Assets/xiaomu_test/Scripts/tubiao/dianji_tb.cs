using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class dianji_tb : MonoBehaviour {

    public static bool name_xiao_hui = false; //销毁


    public RuntimeAnimatorController name_controller; //物体动画


    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        dong_hua();


    }

    void dong_hua()
    {

        if (cai_bei_c.value_js >= 1)
        {
            gameObject.GetComponent<Animator>().runtimeAnimatorController = name_controller;
        }

    }


    void OnMouseDown()
    {
        if(cai_bei_c.value_js >= 1)
        {
            name_xiao_hui = true;
            //Destroy(go);


        }
    }

}
