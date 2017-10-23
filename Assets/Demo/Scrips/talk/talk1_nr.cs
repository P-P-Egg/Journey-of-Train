using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk1_nr : MonoBehaviour {

    private TextMesh text1;    

	void Start () {
        text1 = gameObject.GetComponentInChildren<TextMesh>();

    }
	
	void Update () {
        fuzhi();
        xiao_hui();

    }

    void xiao_hui() //自动销毁自己
    {
        Destroy(gameObject,5);
        
    }

    void OnMouseEnter() //鼠标进入时变成黄色
    {
        text1.color = Color.yellow;
        
    }

    void OnMouseExit()//鼠标退出时变成白色
    {
        text1.color = Color.white;
    } 

    void OnMouseDown() //当鼠标点击时,记录话，销毁自己
    {
        Destroy(gameObject);
        
    }
     
    void OnDestroy() //销毁时
    {
        manager.talk1_id++;
    }

    void fuzhi() //给TEXT赋值
    {
        
        if (manager.talk1_id == 10000)
        {
            text1.text = "哇..你是我见过最没钱的乘务员，你是怎么做到的？";
        }

        if (manager.talk1_id == 10001)
        {
            text1.text = "多学学你的前辈，他们很擅长把人丢进监狱。";
        }

        if (manager.talk1_id == 10002)
        {
            text1.text = "我们家小孩失联好几周了，这是他的照片，你见过的话一定要告诉我。";
        }

        if (manager.talk1_id == 10003)
        {
            text1.text = "又是失联？这几天遇到好几个找小孩的，你们都不报警啊。";
        }

        if (manager.talk1_id == 10004)
        {
            text1.text = "怎么没报警，警察一直说等消息，我们不能干等啊。";
        }

        if (manager.talk1_id == 10005)
        {
            text1.text = "成吧，有没有备份的照片，给我一张。";
        }

        if (manager.talk1_id == 10006)
        {
            text1.text = "有的，谢谢了。";
        }
    }

}
