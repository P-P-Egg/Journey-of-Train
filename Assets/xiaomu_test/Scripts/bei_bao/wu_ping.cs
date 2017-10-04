using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wu_ping : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {        
        bei_bao.wuping_name = this.name; //点击物品后，让变量name等于其名字
    }

}
