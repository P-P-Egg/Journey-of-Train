using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newnpc : MonoBehaviour {

    private float speed; //声明个速度变量

    private Rigidbody2D rg_2d; //自身刚体

    public static Vector3 npcName_weizhi; //自身NPC的位置



    // Use this for initialization
    void Start () {
        rg_2d = GetComponent<Rigidbody2D>();

        

    }
	
	// Update is called once per frame
	void Update () {
        npcName_weizhi = gameObject.transform.position;

        An_jian();

        name_kao_jin();


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



    void name_kao_jin()
    {

        float go = npcName_weizhi.x - npc_jian_ce.name_list_p_x; //NPC位置 - 第一个元素位置
        if (go <= 0) //负数往右走
        {
            rg_2d.AddForce(new Vector2(10, 0));
        }
        if (go > 0) //正数往左走
        {
            rg_2d.AddForce(new Vector2(-10, 0));
        }


    }


    //void name_kao_jin1() //附近有完成的工作 npc就靠近
    //{
    //    npc_jian_ce n_j_c = new npc_jian_ce();

    //    List<float> kao_jin_ju_li = new List<float>(); //npc需要靠近的距离

    //    for (int i = 0;i < n_j_c.name_tu_biao.Count ; i++)
    //    {
    //        kao_jin_ju_li[i] = System.Math.Abs(npcName_weizhi.x - n_j_c.name_tu_biao[i].transform.position.x);
    //    }
        
    //}
}
