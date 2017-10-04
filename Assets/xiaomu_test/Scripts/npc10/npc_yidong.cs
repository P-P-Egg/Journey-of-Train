using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_yidong : MonoBehaviour {

    private Vector3 dian_pos; //点击后鼠标的世界坐标
    private Vector3 screenPos; //屏幕坐标

    private Vector3 jue_se_pos; //角色自身

    bool chushi_ps = false;


    private Vector3 velocity = Vector3.zero; //没什么用的

    private float jue_se_speed = 5;

    //private Rigidbody2D rg_2d;


    // Use this for initialization
    void Start () {
        //rg_2d = GetComponent<Rigidbody2D>();
        screenPos = Camera.main.WorldToScreenPoint(transform.position);



    }
	
	// Update is called once per frame
	void Update () {
        //An_jian();

        yidong();





    }

    //void An_jian()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        rg_2d.AddForce(new Vector2(0, 15));
    //    }

    void yidong()
    {
       
        if (Input.GetMouseButtonDown(0))  //鼠标点击后，获取鼠标位置
        {
           
            Vector3 dianV = Input.mousePosition;
            dianV.z = screenPos.z;
            Debug.Log(dianV);

            dian_pos = Camera.main.ScreenToWorldPoint(dianV);
            dian_pos.z = screenPos.z;
            Debug.Log(dian_pos);

            chushi_ps = true;

        }

        if(chushi_ps)  //角色移动到鼠标位置
        {

            //Vector3 dao_da = new Vector3(dian_pos.x, transform.position.y, transform.position.z);

            //transform.position = Vector3.SmoothDamp(transform.position, dao_da,ref velocity, su_lv);


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
