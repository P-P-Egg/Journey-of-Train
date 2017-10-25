using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box2 : MonoBehaviour
{

    private int box = 2; //几号包

    public GameObject jubaolight;//高亮举报


    public static bool box2_bool; //被举报的bool

    void Start()
    {

    }

    void Update()
    {
        if (transform.name == ju_bao1.ju_bao_name && box2_bool == false)
        {
            ju_bao_hou();
        }
    }

    private void OnMouseDown()
    {
        zong_liang.box_name = transform.name; //全局等于名字，名字也是ID

        zong_liang.npc_box_int = box;

        zong_liang.wu_ping_miao_su = "普普通通的勺子，看上去格外的干净。";


    }

    void ju_bao_hou()
    {

        jubaolight.GetComponent<Transform>().Translate(0, 0, -3f); //显示举报标记
        box2_bool = true;

    }


}
