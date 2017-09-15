using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newnpc : MonoBehaviour {

    private float speed;

    private Rigidbody2D rg_2d;

    public static Vector2 npc_weizhi; //自身NPC的位置

	// Use this for initialization
	void Start () {
        rg_2d = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        An_jian();
        npc_weizhi = gameObject.transform.position;
        


    }




    void An_jian()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rg_2d.AddForce(new Vector2(0,15));
        }

        if (Input.GetKey(KeyCode.S))
        {
            rg_2d.AddForce(new Vector2(0, -5));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rg_2d.AddForce(new Vector2(-10, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rg_2d.AddForce(new Vector2(10, 0));
        }
    }


    void Wan_cheng_kao_jin() //附近有完成的工作 npc就靠近去点
    {



    }

    void Kao_jin_wan_cheng() //NPC靠近之后，完成任务
    {




    }

}
