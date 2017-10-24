using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.EventSystems;

public class zhujue_yidong : MonoBehaviour {

    public static Vector3 dian_pos; //点击后鼠标的世界坐标

    public AudioSource zhu_jue_sy; //音效

    private Vector3 screenPos; //屏幕坐标

    public Vector3 jue_se_pos; //角色自身

    public static bool chushi_ps = false; //摄像机的一个bool

    private Vector3 velocity = Vector3.zero; //没什么用的

    public float jue_se_speed = 4.5f; //角色移动速度

    private Animator animator; //动画

    private Vector3 jue_se_sca;//角色大小

    private Vector3 jue_se_pos2;//点击时角色位置

    private Vector3 jue_se_oldpos;//上一帧角色位置

    private Vector3 jue_se_cha;//位置差

    private Vector3 dian2;
    private Vector3 dian3;

    public bool left;
    public bool right;


    void Start () {
        screenPos = Camera.main.WorldToScreenPoint(transform.position);
        animator = GetComponent<Animator>();
    }
	

	void Update () {


        if (manager.talk1_bool_js)
        {
            if (Time.timeScale != 0)
            {
                yidong();
                Animation();
            }
            jue_se_pos = transform.position;
            if (jue_se_oldpos == Vector3.zero)
            {
                //什么也不干
            }
            else
            {
                jue_se_cha = jue_se_pos - jue_se_oldpos;
            }
            jue_se_oldpos = jue_se_pos;

            if (Input.GetMouseButtonDown(0))
            {
                zhu_jue_sy.Play(); //主角脚步声
            }
        }

    }

     
    void Animation()  //动画
    {

        if (right)
        {
            if (jue_se_cha.x != 0)
            {
                animator.SetTrigger("zj_r_run");
            }
            else
            {
                animator.SetTrigger("zj_right");

                zhu_jue_sy.Stop(); //脚步声停止
            }
        }
        if (left)
        {
            if (jue_se_cha.x != 0)
            {
                animator.SetTrigger("zj_l_run");
            }
            else
            {
                animator.SetTrigger("zj_left");

                zhu_jue_sy.Stop(); //脚步声停止
            }
        }



    }

    void yidong() //角色移动
    {
        if (Input.GetMouseButtonDown(0)/* && !EventSystem.current.IsPointerOverGameObject()*/)  //鼠标点击后，获取鼠标位置
        {
      
       

            Vector3 dianV = Input.mousePosition;
            dianV.z = screenPos.z;

            dian_pos = Camera.main.ScreenToWorldPoint(dianV);

            chushi_ps = true;

            jue_se_pos2 = jue_se_pos;


        }
        if (chushi_ps)  //角色移动到鼠标位置
        {
            if (dian_pos.x - transform.position.x > 0.2f)  //如果点击的位置大于角色位置
            {
                
                transform.Translate(Vector3.right * Time.deltaTime * jue_se_speed, Space.World);

                
                right = true;
                left = false;
            }

            if (dian_pos.x - transform.position.x < 0) //如果点击位置小于角色位置
            {
                transform.Translate(Vector3.left * Time.deltaTime * jue_se_speed, Space.World);

                
                right = false;
                left = true;
            }
        }

    }
}
