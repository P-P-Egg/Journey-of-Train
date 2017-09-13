using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class tu_biao : MonoBehaviour {

    public static Slider workSlider;

    public static float value_js = 0;

    void Awake()
    {
        chu_shi_hua();
    }


    void Start () {
		
	}
	

	void Update () {
        work_slider();


    }

    void chu_shi_hua()//初始化游戏
    {
        workSlider = GameObject.Find("WorkSlider").GetComponent<Slider>();
        /*workSlider.enabled = false; *///不启用
    }

    void work_slider()
    {
        workSlider.value = value_js;
        if(value_js <= 1)
        {
            value_js += 0.005f;
        }
        
    }
}
