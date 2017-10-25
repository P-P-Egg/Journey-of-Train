using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bao_zhi : MonoBehaviour {

    public Transform zhu_jue;

    private bool dian_ji;

    private float zhu_jue_x;

    private float ju_li_x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ju_li();

        if (dian_ji && ju_li_x <= 1f)
        {
            kao_jin();
            dian_ji = false;
        }

        Debug.Log(ju_li_x);
	}

    void ju_li()
    {
       
        ju_li_x = Vector3.Distance(zhu_jue.position, transform.position); ;
    }

    void OnMouseDown()
    {
        dian_ji = true;
        
    }

    void kao_jin()
    {
        mu_1.mu_1_bool = true;
        bao_zhi_animator.bao_zhi_animator_bool = true;
    }
}
