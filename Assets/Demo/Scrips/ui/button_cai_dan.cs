using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_cai_dan : MonoBehaviour {

    private TextMesh text;
	
	void Start () {
        text = gameObject.GetComponentInChildren<TextMesh>();

    }
	
	
	void Update () {
		
	}

    void OnMouseEnter() //鼠标进入时变成白色
    {
        text.color = Color.white;
    }

    void OnMouseExit()//鼠标退出时变成黑色
    {
        text.color = Color.black;
    }

    void OnMouseDown() //当鼠标点击时
    {
        if(gameObject.name == "button_kai")
        {
            Application.LoadLevel("Main");
        }
        
    }
}
