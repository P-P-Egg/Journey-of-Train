using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mu_2 : MonoBehaviour {

    public static bool mu_2_bool; //是否开启

    private Animator animator; //动画



    void Start()
    {
        animator = GetComponent<Animator>();

    }


    void Update()
    {
        if (mu_2_bool)
        {
            transform.position = new Vector3(14.47f, 0.86f, -4f);

            animator.SetTrigger("mu_1_trigger");

            mu_2_bool = false;
        }

    }

    void OnMouseDown()
    {
        transform.position = new Vector3(14.47f, 0.86f, 3f);

        //以下对话时间启动 角色可以移动
        manager.talk1_bool_js = true;
        manager2.talk2_bool_js = true;
    }
}
