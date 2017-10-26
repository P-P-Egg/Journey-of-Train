using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mu_1 : MonoBehaviour {

    public static bool mu_1_bool; //是否开启

    private Animator animator; //动画



    void Start () {
        animator = GetComponent<Animator>();

    }
	

	void Update () {
        if (mu_1_bool)
        {
            transform.position = new Vector3(14.47f, 0.86f,-4.8f);

            animator.SetTrigger("mu_1_trigger");

            mu_1_bool = false;
        }

    }

    void OnMouseDown()
    {
        transform.position = new Vector3(14.47f, 0.86f, 2f);
        bao_zhi_animator.bao_zhi_guan_bool = true;

       
    }
}
