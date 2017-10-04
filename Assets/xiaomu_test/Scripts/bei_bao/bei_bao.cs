using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bei_bao : MonoBehaviour {

    public static string wuping_name;  //点击物品后获得的name

    public static string shanchu_name; //点击物品后删除的名字
    public static int shanchu_cishu = 0; //点击物品后删除的次数

    public SpriteRenderer k_1_sp;  //物品栏
    public SpriteRenderer k_2_sp;
    public SpriteRenderer k_3_sp;
    public SpriteRenderer k_4_sp;

    List<SpriteRenderer> k_t_list = new List<SpriteRenderer>(); //框的图片list


    public Sprite mao_1; //取得帽子1
    public Sprite mao_2; //取得帽子2
    public Sprite mao_3; //取得帽子3
    

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

    void OnMouseDown()
    {

    }



    void suibian() //初始化
    {
        
        k_t_list.Add(k_1_sp); 
        k_t_list.Add(k_2_sp);
        k_t_list.Add(k_3_sp);
        k_t_list.Add(k_4_sp);

    }


    void fang_bei_bao() //将点击的物体放进背包
    {
        Sprite sp = null;
        if (wuping_name == "mao1") //根据变量name，为物品栏赋值
        {
            sp = mao_1;
        }
        if (wuping_name == "mao2")
        {
            sp = mao_2;

        }
        if (wuping_name == "mao3")
        {
            sp = mao_3;
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

        if(shanchu_name == "mao1_JB") //判断需要删除的物品
        {
            int 拥有数 = 0;

            for (int i = 0; i < k_t_list.Count; i++) //判断需要删除物品是否足够
            {
                if (k_t_list[i].sprite == mao_1)
                {
                    拥有数++;
                }
            }

            if(拥有数 >= shanchu_cishu) //物品足够开始进行删除
            {
                for (int i = 0; i < k_t_list.Count; i++)
                {
                    if (k_t_list[i].sprite == mao_1)
                    {
                        k_t_list[i].sprite = null;
                        shanchu_cishu --;
                        if(shanchu_cishu == 0)
                        {
                            break;
                        }
                    }
                }
            }
                        
            shanchu_name = null;

        }
            
    }

}
