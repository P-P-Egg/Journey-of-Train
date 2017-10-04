using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiang_ji_yidong : MonoBehaviour {

    public Transform zhu_jue; //主角的坐标

    private Vector3 pian_yi; //偏移
     
    private Vector3 v = new Vector3(0, 0, 0); //没用的

	// Use this for initialization
	void Start () {
        pian_yi = transform.position - zhu_jue.position;

    }
	
	// Update is called once per frame
	void Update () {
        //if (transform.position.x >= -7.0f && transform.position.x <= 7.0f)
        //{
        //    transform.position = pian_yi + zhu_jue.position;
        //}

        //pian_yi + zhu_jue.position
        if (npc_yidong.chushi_ps) //相机跟随，包含动态平滑效果
        {
            float sx_x = transform.position.x;           
            float sx_z = transform.position.z;
            transform.position = Vector3.SmoothDamp(new Vector3(sx_x,0, sx_z), pian_yi + npc_yidong.dian_pos, ref v, 1);
        }



    }
}
