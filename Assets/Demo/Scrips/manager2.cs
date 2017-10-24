using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager2 : MonoBehaviour {


    public Transform zhujue_pos;    

    private float daltatime;
    public static bool talk2_bool_js; //talk1 计时bool 等主线结束开始计时
    public float Level_time = 0; //当前关卡使用的总时间
    private int ji_suan_time = 5;

    public GameObject text1; //要被实例化的物体
    public GameObject text2;
    public GameObject text_zhujue;

    public static int talk2_id = 20000;//text1的对话的ID，这个控制该说哪句话

    private bool[] talk2_boll = new bool[1000]; //对话只能使用1次    


    private Vector3 npc_pian_yi;

    private Vector3 出租车pos;
    private Vector3 老师pos;
    private Vector3 学生男pos;
    private Vector3 公司职员pos;
    private Vector3 酒鬼男pos;

    public Transform 出租车;
    public Transform 老师;
    public Transform 学生男;
    public Transform 公司职员;
    public Transform 酒鬼男;


    void Start()
    {
        NPC_pos();
        talk_chen_wu.Level = 2; //标记是关卡1
    }


    void Update()
    {
        //Level_time = Time.timeSinceLevelLoad;
        ji_shi();
        talk1_kz();
      
    }


    void ji_shi() //手动的游戏计时
    {
        daltatime += Time.deltaTime;
        if (daltatime > 1 && talk2_bool_js)
        {
            Level_time++;
            daltatime = 0;
        }
    }

    void shi_li(Object ob, Vector3 v3, Quaternion qua, int talk_b) //实例对话框和字加时间判断
    {
        Instantiate(ob, v3, qua);
        talk2_boll[talk_b] = true;
        ji_suan_time += 7;
    }

    void NPC_pos() //NPC对话框弹出的位置
    {
        npc_pian_yi = new Vector3(-0.5f, 2.7f, 0);
        学生男pos = 学生男.position + npc_pian_yi;
        出租车pos = 出租车.position + npc_pian_yi;
        老师pos = 老师.position + npc_pian_yi;
        公司职员pos = 公司职员.position + npc_pian_yi;
        酒鬼男pos = 酒鬼男.position + npc_pian_yi;
    }


    void talk1_kz() //控制弹出的对话talk1
    {

        if (talk2_boll[0] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 公司职员pos, transform.rotation, 0);
        }
        if (talk2_boll[1] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 公司职员pos, transform.rotation, 1);

        }
        if (talk2_boll[2] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 公司职员pos, transform.rotation, 2);

        }

        if (talk2_boll[3] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 学生男pos, transform.rotation, 3);
        }

        if (talk2_boll[4] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 学生男pos, transform.rotation, 4);

        }

        if (talk2_boll[5] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 学生男pos, transform.rotation, 5);

        }

        if (talk2_boll[6] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 老师pos, transform.rotation, 6);

        }

        if (talk2_boll[7] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 老师pos, transform.rotation, 7);

        }

        if (talk2_boll[8] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 老师pos, transform.rotation, 8);

        }

        if (talk2_boll[9] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 出租车pos, transform.rotation, 9);
        }

        if (talk2_boll[10] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 出租车pos, transform.rotation, 10);
        }

        if (talk2_boll[11] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 出租车pos, transform.rotation, 11);
        }

        if (talk2_boll[12] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 出租车pos, transform.rotation, 12);
        }

        if (talk2_boll[13] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 出租车pos, transform.rotation, 13);
        }

        if (talk2_boll[14] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 酒鬼男pos, transform.rotation, 14);
        }

        if (talk2_boll[15] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 酒鬼男pos, transform.rotation, 15);
        }

        if (talk2_boll[16] != true && Level_time == ji_suan_time)
        {
            shi_li(text2, 酒鬼男pos, transform.rotation, 16);
        }


    }


}

