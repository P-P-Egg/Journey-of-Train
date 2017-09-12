using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiao_hui : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(dianji_tb.all_xiao_hui)
        {
            Destroy(gameObject);
        }
	}
}
