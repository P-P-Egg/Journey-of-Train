using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk2_nr : MonoBehaviour {

    private TextMesh text2;

    void Start()
    {
        text2 = gameObject.GetComponentInChildren<TextMesh>();
        fuzhi();
    }

    void Update()
    {

        xiao_hui();

    }

    void xiao_hui() //自动销毁自己
    {
        Destroy(gameObject, 5);

    }

    void OnMouseEnter() //鼠标进入时变成黄色
    {
        text2.color = Color.yellow;

    }

    void OnMouseExit()//鼠标退出时变成白色
    {
        text2.color = Color.white;
    }

    void OnMouseDown() //当鼠标点击时,记录话，销毁自己talk2_boll
    {
        Destroy(gameObject);
    }

    void OnDestroy() //销毁时
    {
        manager2.talk2_id++;
    }

    void fuzhi() //给TEXT赋值
    {

        if (manager2.talk2_id == 20000)
        {
            text2.text = "包里的照片是我儿子，他\n擅长用乐高创造的建筑。";
        }

        if (manager2.talk2_id == 20001)
        {
            text2.text = "小孩子都喜欢一边建造一\n边破坏。";
        }

        if (manager2.talk2_id == 20002)
        {
            text2.text = "照片里他正在试图推倒一\n面乐高拼起的围墙。";
        }

        if (manager2.talk2_id == 20003)
        {
            text2.text = "肯尼迪当年在柏林演讲时\n说：";
        }

        if (manager2.talk2_id == 20004)
        {
            text2.text = "我们从未建造一堵墙把人\n民关在里面，不准离开。";
        }

        if (manager2.talk2_id == 20005)
        {
            text2.text = "看来快要食言了。";
        }

        if (manager2.talk2_id == 20006)
        {
            text2.text = "别忘了肯尼迪的前两句话：";
        }

        if (manager2.talk2_id == 20007)
        {
            text2.text = "自由有许多困难，民主亦\n非完美。";
        }

        if (manager2.talk2_id == 20008)
        {
            text2.text = "现在可能是它不完美的时\n候。";
        }

        if (manager2.talk2_id == 20009)
        {
            text2.text = "你们上学就为了表达不满\n吗？成天示威。";
        }

        if (manager2.talk2_id == 20010)
        {
            text2.text = "身在福中不知福的家伙，\n应该把你们送到沙特，";
        }

        if (manager2.talk2_id == 20011)
        {
            text2.text = "在滚烫的沙漠里受苦，才\n知道国家有多好。";
        }


        if (manager2.talk2_id == 20012)
        {
            text2.text = "昨天遇到个学生，撞坏了\n我的车还直接跑了。";
        }


        if (manager2.talk2_id == 20013)
        {
            text2.text = "你们先学会做人吧。";
        }


        if (manager2.talk2_id == 20014)
        {
            text2.text = "我每天都会看特瑞普的演\n讲。";
        }

        if (manager2.talk2_id == 20015)
        {
            text2.text = "我敢发誓，那是我一天中\n最开心的时候。";
        }

        if (manager2.talk2_id == 20016)
        {
            text2.text = "特瑞普绝对是他妈的历史\n上最会用手演讲的总统。";
        }

    }
}
