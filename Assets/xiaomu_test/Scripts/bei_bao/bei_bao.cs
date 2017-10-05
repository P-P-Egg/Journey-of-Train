using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bei_bao : MonoBehaviour {

    public Transform zhu_jue; //主角位置
    public static string wuping_name;  //点击物品后获得的name

    public static string shanchu_name; //点击物品后删除的名字
    public static int 删除次数 = 1; //点击物品后删除的次数

    public SpriteRenderer k_1_sp;  //物品栏
    public SpriteRenderer k_2_sp;
    public SpriteRenderer k_3_sp;
    public SpriteRenderer k_4_sp;

    List<SpriteRenderer> k_t_list = new List<SpriteRenderer>(); //框的图片list


    public Sprite wu_ping_1; //物品的图片
    public Sprite wu_ping_2; 
    public Sprite wu_ping_3;

    bool xian = false; //背包的显示

    void Start () {
       
        suibian();

    }
	
	void Update () {



        if(wuping_name != null)
        {
            fang_bei_bao();
        }

        if(shanchu_name != null)
        {
            shan_chu();
        }       
    }

    void suibian() //初始化
    {
        transform.position = new Vector3(0, 100, 0); //起始位置让背包不可见

        k_t_list.Add(k_1_sp); 
        k_t_list.Add(k_2_sp);
        k_t_list.Add(k_3_sp);
        k_t_list.Add(k_4_sp);

    }

    public void xian_shi() //显示背包 和 隐藏背包
    {
        
        if(xian == false)
        {
            transform.position = new Vector3((18 - 24) + zhu_jue.position.x, 2.5f, 0);
            xian = true;
        }
        else
        {
            transform.position = new Vector3(0, 100, 0);
            xian = false;
        }
        
    }


    void fang_bei_bao() //将点击的物体放进背包
    {
        Sprite sp = null;
        if (wuping_name == "ka_fei") //根据变量name，为物品栏赋值
        {
            sp = wu_ping_1;
        }
        if (wuping_name == "mao_jia")
        {
            sp = wu_ping_2;

        }
        if (wuping_name == "mao3")
        {
            sp = wu_ping_3;
        }

        wuping_name = null;

        for (int i = 0; i < k_t_list.Count;i++) //将点击物品的图片实例化进入背包
        {

            if (k_t_list[i].sprite == null)
            {
                k_t_list[i].sprite = sp;
                break;                
            }
        }
    }

    void shan_chu() //将物品删除
    {
        Sprite sp = null;
        if (shanchu_name == "bai_kafei") //判断需要删除的物品
        {
            sp = wu_ping_1;
        }
        if(shanchu_name == "bai_mao")
        {
            sp = wu_ping_2;
        }

        if(sp!= null)
        {
            int 拥有数 = 0;

            for (int i = 0; i < k_t_list.Count; i++) //判断需要删除物品是否足够
            {
                if (k_t_list[i].sprite == sp)
                {
                    拥有数++;
                }

            }

            if (拥有数 >= 删除次数) //物品足够开始进行删除
            {
                for (int i = 0; i < k_t_list.Count; i++)
                {
                    if (k_t_list[i].sprite == sp)
                    {
                        k_t_list[i].sprite = null;
                        删除次数 --; 
                        if(删除次数 == 0)
                        {
                            删除次数 = 1;
                            break;
                        }
                    }
                }
            }                        
            shanchu_name = null;
        }            
    }


 
}
