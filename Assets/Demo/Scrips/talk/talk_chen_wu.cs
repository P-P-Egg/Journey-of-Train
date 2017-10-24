using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk_chen_wu : MonoBehaviour {

    private float daltatime;
    public float Level_time = 0; //当前关卡使用的总时间

    private TextMesh text_chen_wu;
    public int dui_hua_int = 0 ;

    private Vector3 a_pos = new Vector3(38.54f, -0.25f, -2f);
    private Vector3 b_pos = new Vector3(34.17f, -0.25f, -2f); //对话框位置

    public static int Level = 0; //判断哪个关卡
    

    void Start () {
        text_chen_wu = gameObject.GetComponentInChildren<TextMesh>();
    }
	
	
	void Update () {
        ji_shi();

        if(Level == 1)
        {
            fu_zhi1();
        }
        if (Level == 2)
        {
            fu_zhi2();
        }
        if (Level == 3)
        {
            
        }
    }
 

    void OnMouseUp()
    {
        dui_hua_int++;
        
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



    void xiao_hui()
    {
        Destroy(gameObject);
    }

    void fu_zhi1() //第一个场景的主线对话
    {
        if (Level_time == 2)
        {
            text_chen_wu.text = "恭喜你成为铁路部的一员，我\n是这辆列车的乘务长，负责指\n导你的工作。";
            transform.position = a_pos;
        }

        if (dui_hua_int == 1)
        {
            text_chen_wu.text = "在总统的领导下，国家正逐步\n走向富强。但有一些叛国者，\n用谎言蒙蔽人民的眼睛。";
        }

        if (dui_hua_int == 2)
        {
            text_chen_wu.text = "警惕周围的乘客，他们携带的\n每一个物品，都可能对国家造\n成不可估量的损失。";
        }

        if (dui_hua_int == 3)
        {
            text_chen_wu.text = "当你发现可疑物品，遵照铁路\n管理规定，依法举报违规物品，\n审核局会公正判决每个举报案。";
        }

        if (dui_hua_int == 4)
        {
            text_chen_wu.text = "当然，如果举报成功，国家将\n给予你奖励，反之则象征性的\n处罚。";
        }

        if (dui_hua_int == 5)
        {
            text_chen_wu.text = "以下每组物品中有1个是违禁\n品。";            
        }
        //下面放背包的信息

        if (dui_hua_int == 6)
        {
            text_chen_wu.text = "没事的时候多看报纸，记住，\n你的资产不能太低，我们不会\n雇佣有损国家形象的人。";
           
        }
        if (dui_hua_int == 7) //如果第七次就消耗自己
        {
            

            hei_mu2.hei_mu2_trigger = true; //播放黑幕动画

            manager.talk1_bool_js = true; //开始播放1关对话

            xiao_hui();
        }

    }

    void fu_zhi2() //第二个场景的主线对话
    {
        if (Level_time == 2)
        {
            transform.position = a_pos;
            text_chen_wu.text = "注意更新的铁路管理手册，现\n在开始，我们有权处罚散布违\n规言论的乘客。";            
        }

        if (dui_hua_int == 1)
        {
            text_chen_wu.text = "先给你演示什么是违规言论。";
        }

        if (dui_hua_int == 2)
        {
            text_chen_wu.text = "1.特瑞普将彻底控制政府。\n2.三权独立是阻止独裁的最后\n一道防火墙。";
        }

        if (dui_hua_int == 3)
        {
            text_chen_wu.text = "刚才第一句话不尊重总统先生，\n第二句话涉及的违规词将损害\n国家利益，明白怎么工作了吗？";
        }

        if (dui_hua_int == 4)
        {
            transform.position = b_pos;
            text_chen_wu.text = "我如何判断哪些是违规词？";
        }

        if (dui_hua_int == 5)
        {
            transform.position = a_pos;
            text_chen_wu.text = "作为国家公务人员，应当具备\n敏锐的“嗅觉”，我不想回答\n这么愚蠢的问题。";
        }
       
        if (dui_hua_int == 6)
        {
            text_chen_wu.text = "认真读一读铁路管理手册，\n现在立刻工作。";
        }
        if (dui_hua_int == 7)
        {
            manager2.talk2_bool_js = true; //开始播放二关话

            hei_mu2.hei_mu2_trigger = true; //播放黑幕动画

            xiao_hui();
        }

            //下面打开铁路管理手册
        }

    void OnMouseEnter() //鼠标进入时变成黄色
    {
        text_chen_wu.color = Color.yellow;

    }

    void OnMouseExit()//鼠标退出时变成白色
    {
        text_chen_wu.color = Color.white;
    }

}
