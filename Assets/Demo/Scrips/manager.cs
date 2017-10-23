using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class manager : MonoBehaviour {

    private float daltatime;
    public float Level_time = 0; //当前关卡使用的总时间，会随着游戏暂停而暂停
    private int ji_suan_time = 5;
    
    public GameObject text1; //要被实例化的物体
    public GameObject text2;

    public static int talk1_id = 10000; //text1的对话的ID，这个控制该说哪句话
    public static int talk2_id = 20000;


    private bool[] talk1_boll = new bool[1000]; //对话只能使用1次    

    private Vector3 npc_pian_yi;

    private Vector3 私人司机pos;
    private Vector3 家庭主妇pos;
    private Vector3 学生男pos;
    private Vector3 建筑工pos;

    public Transform 私人司机;
    public Transform 家庭主妇;
    public Transform 学生男;
    public Transform 建筑工;



    void Start () {
        NPC_pos();
    }
	
	
	void Update () {
        //Level_time = Time.timeSinceLevelLoad;
        ji_shi();
        talk_kz();

        
    }


    void ji_shi() //手动的游戏计时
    {
        daltatime += Time.deltaTime;
        if (daltatime > 1)
        {
            Level_time++;
            daltatime = 0;
        }
    }

    void NPC_pos() //NPC对话框弹出的位置
    {
        npc_pian_yi = new Vector3(-0.5f, 2.7f, 0);
        学生男pos = 学生男.position + npc_pian_yi;
        私人司机pos = 私人司机.position + npc_pian_yi;
        家庭主妇pos = 家庭主妇.position + npc_pian_yi;
        建筑工pos = 建筑工.position + npc_pian_yi;
    }


    void talk_kz() //控制弹出的对话
    {
        
        if (talk1_boll[0] != true && Level_time == ji_suan_time) //学生男
        {
            Instantiate(text1, 学生男pos, transform.rotation);
            talk1_boll[0] = true;
            ji_suan_time += 7;
        } 
        if(talk1_boll[1] != true && Level_time == ji_suan_time) //学生男
        {
            Instantiate(text1, 学生男pos, transform.rotation);
            talk1_boll[1] = true;
            ji_suan_time += 7;
        }
        if (talk1_boll[2] != true && Level_time == ji_suan_time)  //家庭主妇
        {
            Instantiate(text1, 家庭主妇pos, transform.rotation);
            talk1_boll[2] = true;
            ji_suan_time += 7;
        }

        if (talk1_boll[3] != true && Level_time == ji_suan_time)  //私人司机
        {
            Instantiate(text1, 私人司机pos, transform.rotation);
            talk1_boll[3] = true;
            ji_suan_time += 7;
        }

        if (talk1_boll[4] != true && Level_time == ji_suan_time)  //建筑工
        {
            Instantiate(text1, 建筑工pos, transform.rotation);
            talk1_boll[4] = true;
            ji_suan_time += 7;
        }

        if (talk1_boll[5] != true && Level_time == ji_suan_time) //私人司机
        {
            Instantiate(text1, 私人司机pos, transform.rotation);
            talk1_boll[5] = true;
            ji_suan_time += 7;
        }

        if (talk1_boll[6] != true && Level_time == ji_suan_time) //家庭妇女
        {
            Instantiate(text1, 家庭主妇pos, transform.rotation);
            talk1_boll[6] = true;
            ji_suan_time += 7;
        }
      
        if (talk1_boll[7] != true && Level_time == ji_suan_time)
        {
            Instantiate(text1, new Vector3(8.11f, 1f, 0), transform.rotation);
            talk1_boll[7] = true;
            ji_suan_time += 7;
        }

        if (talk1_boll[8] != true && Level_time == ji_suan_time)
        {
            Instantiate(text1, new Vector3(8.11f, 1f, 0), transform.rotation);
            talk1_boll[8] = true;
            ji_suan_time += 7;
        }

        if (talk1_boll[9] != true && Level_time == ji_suan_time)
        {
            Instantiate(text1, new Vector3(8.11f, 1f, 0), transform.rotation);
            talk1_boll[9] = true;
            ji_suan_time += 7;
        }

    }
}
