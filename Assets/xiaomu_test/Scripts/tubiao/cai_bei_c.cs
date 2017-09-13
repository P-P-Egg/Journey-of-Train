using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cai_bei_c : MonoBehaviour {

    public static Slider name_Slider;

    public static float value_js = 0;


    void Awake()
    {
        
    }


    void Start () {
        chi_shi_hua();

    }
	

	void Update () {

        work_slider();

        if (dianji_tb.name_xiao_hui)
        {
            Destroy(gameObject);
        }
    }

    void chi_shi_hua()
    {
        name_Slider = GameObject.Find("name_Slider").GetComponent<Slider>();
    }

    void work_slider()
    {
        name_Slider.value = value_js;
        if (value_js <= 1)
        {
            value_js += 0.005f;
        }

    }
}
