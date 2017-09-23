using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_jian_ce : MonoBehaviour {

    public  List<GameObject> name_tu_biao = new List<GameObject>(); //存储周围图标的列表

    public static float name_list_p_x; //第一个元素的位置的X值

    void Start()
    {

    }

    void Update()
    {
        gameObject.transform.position = newnpc.npcName_weizhi; //让自己位置始终跟随NPC

        shua_xin_list();


        list_position();


    }



    void OnTriggerEnter2D(Collider2D col2d) //进入触发器
    {
        if(col2d.tag == "tubiao")
        {
            name_tu_biao.Add(col2d.gameObject);
        }
    }

    //void OnCollisionStay2D(Collider2D col2d) //逗留触发器
    //{
    //    if (col2d.tag == "tubiao")
    //    {
    //        name_tu_biao.Add(col2d.gameObject);
    //    }
    //}


    void OnTriggerExit2D(Collider2D col2d) //退出触发器
    {
        if (col2d.tag == "tubiao")
        {
            name_tu_biao.Remove(col2d.gameObject);
        }
    }

    void shua_xin_list() //清单中途元素被销毁，对列表进行刷新
    {
        List<int> tubiao_int = new List<int>();

        for(int index = 0; index < name_tu_biao.Count; index++)
        {
            if(name_tu_biao[index] == null)
            {
                tubiao_int.Add(index);
            }

        }

        for(int i = 0;i < tubiao_int.Count; i++)
        {
            name_tu_biao.RemoveAt(tubiao_int[i] - i);
        }
    }

    void list_position() //第一个元素的位置的X值
    {

        name_list_p_x = name_tu_biao[0].transform.position.x;

    }

}
