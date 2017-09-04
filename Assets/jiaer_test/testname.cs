using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testname : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        GameObject.Find("Canvas/Xiaomu").GetComponent<TextMesh>().text = "小木";
    }
}
