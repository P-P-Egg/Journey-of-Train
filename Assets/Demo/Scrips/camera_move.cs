using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour {

    public Transform zhu_jue; //主角的坐标

    private Vector3 pian_yi; //偏移

    private Vector3 v = new Vector3(0, 0, 0); //没用的

    private Vector3 camera_pos;

    private Vector3 mouse_pos;

    void Start () {
        pian_yi = transform.position - zhu_jue.position;
       
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //camera_pos = transform.position;
        if (zhujue_yidong.chushi_ps && transform.position.x < 82.2f && mouse_pos.x > zhu_jue.position.x) //相机跟随，包含动态平滑效果
        {
            float sx_x = transform.position.x;
            float sx_z = transform.position.z;
            transform.position = Vector3.SmoothDamp(new Vector3(sx_x, 0, sx_z), pian_yi + zhujue_yidong.dian_pos, ref v, 1);
        }
        if (zhujue_yidong.chushi_ps && transform.position.x > 0 && mouse_pos.x < zhu_jue.position.x) //相机跟随，包含动态平滑效果
        {
            float sx_x = transform.position.x;
            float sx_z = transform.position.z;
            transform.position = Vector3.SmoothDamp(new Vector3(sx_x, 0, sx_z), pian_yi + zhujue_yidong.dian_pos, ref v, 1);
        }
    }
}
