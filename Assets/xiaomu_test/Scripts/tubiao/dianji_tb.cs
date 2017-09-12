using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class dianji_tb : MonoBehaviour {

    private GameObject tubiao_1;
    private Animation tibiao_a_1;

    public static bool all_xiao_hui = false;

    public RuntimeAnimatorController controller;

    public GameObject qian;
    private GameObject qian_fu;


    // Use this for initialization
    void Start () {
        tubiao_1 = this.gameObject;


    }
	
	// Update is called once per frame
	void Update () {
        dong_hua();


    }

    void dong_hua()
    {

        if (tu_biao.value_js >= 1)
        {
            gameObject.GetComponent<Animator>().runtimeAnimatorController = controller;
        }

    }


    void OnMouseDown()
    {
        if(tu_biao.value_js >= 1)
        {
            Destroy(gameObject);
            all_xiao_hui = true;
            GameObject go = GameObject.Instantiate(qian, new Vector3(0, 0, 0), Quaternion.identity);
            //Destroy(go);


        }
    }

}
