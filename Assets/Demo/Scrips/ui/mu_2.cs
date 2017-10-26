using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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


        if (manager.talk1_bool_js || manager2.talk2_bool_js)
        {
            transform.position = new Vector3(14.47f, 0.86f, 3f);

            
        }

    }

    void OnMouseDown()
    {
        
        if (!EventSystem.current.IsPointerOverGameObject()) //点击自身后 并且没有在UI上
        {
            transform.position = new Vector3(14.47f, 0.86f, 3f);

            
            GameObject.FindWithTag("backpack").SetActive(false);

            //以下对话时间启动 角色可以移动
            manager.talk1_bool_js = true;
            manager2.talk2_bool_js = true;    

        }
       
    }
}
