﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jubao : MonoBehaviour {
    public GameObject[] jubaowupin = new GameObject[9];//举报物品
    private Vector3 originscale;
    public float xmax;
    public float ymax;
    // Use this for initialization
    void Start () {
        originscale = transform.localScale;
        xmax = 1.5f * transform.localScale.x;
        ymax = 1.5f * transform.localScale.y;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
    private void OnMouseOver()
    {
        Vector3 change = new Vector3(Time.deltaTime, Time.deltaTime, 0);
        if (transform.localScale.x <= xmax && transform.localScale.y < ymax)
        {
            transform.localScale += change;
        }
    }
    private void OnMouseExit()
    {
        transform.localScale = originscale;
    }

    private void OnMouseDown()
    {
        foreach(GameObject jubaowu in jubaowupin)
        {
            if (jubaowu.GetComponent<timepiece>().isjubao)
            {
                GameObject.FindWithTag("jubaoxinxi").GetComponent<Text>().text += jubaowu.GetComponent<timepiece>().npc+":\n"+jubaowu.GetComponent<timepiece>().information+"\n";
            }
        }
    }
}
