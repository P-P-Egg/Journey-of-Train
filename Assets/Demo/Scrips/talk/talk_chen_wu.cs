using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk_chen_wu : MonoBehaviour {

    private float daltatime;
    public float Level_time = 0; //当前关卡使用的总时间

    private TextMesh text_chen_wu;
    private Vector3 a_pos = new Vector3(38.74f, -0.24f,0);
    private Vector3 b_pos = new Vector3(34.52f, -0.24f, 0);

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
            fu_zhi1();
        }
        if (Level == 3)
        {
            fu_zhi1();
        }
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
        if (Level_time == 47)
        {
            Destroy(gameObject);
        }
    }

    void fu_zhi1()
    {
        if (Level_time == 2)
        {
            text_chen_wu.text = "恭喜你成为铁路部的一员，我\n是这辆列车的乘务长，负责指\n导你的工作。";
            transform.position = a_pos;
        }

        if (Level_time == 9)
        {
            text_chen_wu.text = "在总统的领导下，国家正逐步\n走向富强。但有一些叛国者，\n用谎言蒙蔽人民的眼睛。";
        }

        if (Level_time == 16)
        {
            text_chen_wu.text = "警惕周围的乘客，他们携带的\n每一个物品，都可能对国家造\n成不可估量的损失。";
        }

        if (Level_time == 23)
        {
            text_chen_wu.text = "当你发现可疑物品，遵照铁路\n管理规定，依法举报违规物品，\n审核局会公正判决每个举报案。";
        }

        if (Level_time == 30)
        {
            text_chen_wu.text = "当然，如果举报成功，国家将\n给予你奖励，反之则象征性的\n处罚。";
        }

        if (Level_time == 37)
        {
            text_chen_wu.text = "以下每组物品中有1个是违禁\n品。";            
        }
        //下面放背包的信息

        if (Level_time == 40)
        {
            text_chen_wu.text = "没事的时候多看报纸，记住，\n你的资产不能太低，我们不会\n雇佣有损国家形象的人。";
            manager.talk1_bool_js = true;
        }

    }

    void fu_zhi2()
    {
        if (Level_time == 2)
        {
            text_chen_wu.text = "恭喜你成为铁路部的一员，我\n是这辆列车的乘务长，负责指\n导你的工作。";
            transform.position = a_pos;
        }

        if (Level_time == 9)
        {
            text_chen_wu.text = "在总统的领导下，国家正逐步\n走向富强。但有一些叛国者，\n用谎言蒙蔽人民的眼睛。";
        }

        if (Level_time == 16)
        {
            text_chen_wu.text = "警惕周围的乘客，他们携带的\n每一个物品，都可能对国家造\n成不可估量的损失。";
        }

        if (Level_time == 23)
        {
            text_chen_wu.text = "当你发现可疑物品，遵照铁路\n管理规定，依法举报违规物品，\n审核局会公正判决每个举报案。";
        }

        if (Level_time == 30)
        {
            text_chen_wu.text = "当然，如果举报成功，国家将\n给予你奖励，反之则象征性的\n处罚。";
        }

        if (Level_time == 37)
        {
            text_chen_wu.text = "以下每组物品中有1个是违禁\n品。";
        }
        //下面放背包的信息

        if (Level_time == 40)
        {
            text_chen_wu.text = "没事的时候多看报纸，记住，\n你的资产不能太低，我们不会\n雇佣有损国家形象的人。";
            manager.talk1_bool_js = true;
        }

        manager2.talk2_bool_js = true;
    }


}
