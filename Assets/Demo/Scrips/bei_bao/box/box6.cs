using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box6 : MonoBehaviour {

    private int box = 2; //几号包

    public GameObject jubaolight;//高亮举报

    public static bool box6_bool; //被举报的bool

    void Start()
    {

    }

    void Update()
    {
        if (transform.name == ju_bao1.ju_bao_name && box6_bool == false)
        {
            ju_bao_hou();
        }
    }

    private void OnMouseDown()
    {
        zong_liang.box_name = transform.name; //全局等于名字，名字也是ID

        zong_liang.npc_box_int = box;

        zong_liang.wu_ping_miao_su = "看上去是把锋利的砍刀，刀刃还透着白光。";
    }

    void ju_bao_hou()
    {

        jubaolight.GetComponent<Transform>().Translate(0, 0, -3f); //显示举报标记
        box6_bool = true;
    }
}
