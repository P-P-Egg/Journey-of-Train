using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class testname : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        GameObject.Find("Canvas/Xiaomu").GetComponent<Text>().text = "小木";
    }
    private void OnMouseExit()
    {
        GameObject.Find("Canvas/Xiaomu").GetComponent<Text>().text = "";
    }
}
