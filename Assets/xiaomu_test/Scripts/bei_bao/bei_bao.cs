using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bei_bao : MonoBehaviour {

    public static string wuping_name;



    public GameObject k_1;
    public GameObject k_2;
    public GameObject k_3;
    public GameObject k_4;

    public SpriteRenderer k_1_sp;
    public SpriteRenderer k_2_sp;
    public SpriteRenderer k_3_sp;
    public SpriteRenderer k_4_sp;

    List<Sprite> k_t_list = new List<Sprite>(); //框的图片list


    public Sprite mao_1; //取得帽子1
    public Sprite mao_2; //取得帽子2
    public Sprite mao_3; //取得帽子3


    void Start () {



    }
	
	void Update () {
        fu_zhi();


    }

    void suibian()
    {
        Sprite[] k_sp = { k_1_sp.sprite, k_2_sp.sprite, k_3_sp.sprite, k_4_sp.sprite };
        k_t_list.AddRange(k_sp); //将几个框的sprit组件放入list
    }

    void fu_zhi()
    {

        if(wuping_name == "mao1")
        {
            k_1_sp.sprite = mao_1;
            wuping_name = null;
            Debug.Log(wuping_name);
        }
        if (wuping_name == "mao2")
        {
            wuping_name = null;
        }
        if (wuping_name == "mao3")
        {
            wuping_name = null;
        }



    }
}
