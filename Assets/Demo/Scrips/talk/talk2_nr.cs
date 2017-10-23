using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk2_nr : MonoBehaviour {

    private TextMesh text2;


    void Start () {
        text2 = gameObject.GetComponentInChildren<TextMesh>();
    }
	
	void Update () {
        fuzhi();
        xiao_hui();
    }

    void xiao_hui() //自动销毁自己
    {
        Destroy(gameObject, 10);

    }

    void OnMouseEnter() //鼠标进入时变成黄色
    {
        text2.color = Color.yellow;

    }

    void OnMouseExit()//鼠标退出时变成白色
    {
        text2.color = Color.white;
    }

    void OnMouseDown() //当鼠标点击时,记录话，销毁自己
    {
        Destroy(gameObject);

    }

    void OnDestroy() //销毁时
    {
        manager.talk2_id++;
    }

    void fuzhi() //给TEXT赋值
    {

    }
}
