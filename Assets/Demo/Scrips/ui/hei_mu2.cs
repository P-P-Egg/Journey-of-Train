using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hei_mu2 : MonoBehaviour {

    private Animator animator; //动画

    public static bool hei_mu2_trigger; //这个变量控制使用黑幕2的动画

    void Start () {
        animator = GetComponent<Animator>();
    }
	
	
	void Update () {
        if (hei_mu2_trigger)
        {
            animator.SetTrigger("hei_mu2_trigger");
        }
       
    }
}
