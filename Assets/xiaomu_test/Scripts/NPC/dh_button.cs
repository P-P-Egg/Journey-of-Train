using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dh_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnbuttonDown() //点击对话框，进行下一句，或者退出
    {
        npc_guanli.Dui_hua_image.enabled = false;
        npc_guanli.Dui_hua_text.enabled = false;
    }
}
