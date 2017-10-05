using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class npc_yidong : MonoBehaviour {

    public static Vector3 dian_pos; //点击后鼠标的世界坐标
    private Vector3 screenPos; //屏幕坐标

    private Vector3 jue_se_pos; //角色自身

    public static bool chushi_ps = false; //摄像机的一个bool

    private Vector3 velocity = Vector3.zero; //没什么用的

    private float jue_se_speed = 5; //角色移动速度


    void Start () {
        
        screenPos = Camera.main.WorldToScreenPoint(transform.position);

    }
	

	void Update () {
        

        yidong();

    }


    void yidong()
    {
       
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())  //鼠标点击后，获取鼠标位置
        {
           
            Vector3 dianV = Input.mousePosition;
            dianV.z = screenPos.z;
            Debug.Log(dianV);

            dian_pos = Camera.main.ScreenToWorldPoint(dianV);
            
            chushi_ps = true;

        }

        if(chushi_ps)  //角色移动到鼠标位置
        {


            if(dian_pos.x - transform.position.x >= 0)  //如果点击的位置大于角色位置
            {
                transform.Translate(Vector3.right * Time.deltaTime* jue_se_speed, Space.World);
            }

            if(dian_pos.x - transform.position.x < 0) //如果点击位置小于角色位置
            {
                transform.Translate(Vector3.left * Time.deltaTime*jue_se_speed, Space.World);
            }                      
        }
    }
}
