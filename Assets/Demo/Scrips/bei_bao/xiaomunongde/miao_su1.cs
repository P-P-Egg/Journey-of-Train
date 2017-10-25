using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miao_su1 : MonoBehaviour {

    private TextMesh text;

	// Use this for initialization
	void Start () {
        text = GetComponent<TextMesh>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = zong_liang.miao_su_zhuan;
        

    }
}
