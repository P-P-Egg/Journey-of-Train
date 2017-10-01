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

        Debug.Log(this.name);
        bei_bao.wuping_name = this.name;

    }

}
