using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class chang_jing : MonoBehaviour {

    public Transform zhu_jue;

    private Vector3 screenPos; //屏幕坐标

    private bool dian_ji;  //点击自己后


    private float ju_li_x; 

    void Start () {
        screenPos = Camera.main.WorldToScreenPoint(transform.position);
    }
	

	//void Update () {


 //       ju_li();

 //       if (dian_ji && ju_li_x <= 2.5f)
 //       {
 //           zhujue_yidong.zhu_jue_dong = false;

 //           dian_ji = false;

 //       }

 //       Debug.Log(zhujue_yidong.zhu_jue_dong);
 //   }

    
    void OnMouseDown()
    {
        zhujue_yidong.zhu_jue_dong = true;
        
        //dian_ji = true;

        
    }

    //void ju_li() //判断距离
    //{

    //    ju_li_x = Vector3.Distance(zhu_jue.position,zhujue_yidong.dian_pos_beiyong);

    //}


}
