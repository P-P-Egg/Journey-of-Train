using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cai_bei_c : MonoBehaviour {

    public static Slider name1_Slider;  

    public static float value_js = 0;

    void Awake()
    {
        Chi_shi_hua();
    }


    void Start () {
        

    }
	

	void Update () {

        Work_slider();

        if (dianji_tb.name_xiao_hui) //销毁本身
        {
            name1_Slider.value = 0;
            Destroy(gameObject);
        }
    }

    void Chi_shi_hua() //初始化
    {
        name1_Slider = GameObject.Find("ca_bei_Canvas/name_Slider").GetComponent<Slider>();   //查找对应的slider 
    }

    void Work_slider() //让slider自加
    {
        name1_Slider.value = value_js;
        if (value_js <= 1)
        {
            value_js += 0.005f;
        }


    }
}
