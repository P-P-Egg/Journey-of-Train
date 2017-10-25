using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light1 : MonoBehaviour {

    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;

    private Vector3 z = new Vector3(0, 0, -0.1f);



    void Start () {
		
	}
	
	
	void Update () {
        yi_dong();
       

    }

    void ji_suan()
    {
        
    }

    void yi_dong()
    {
        if(zong_liang.npc_box_int == 1 )
        {
            transform.position = box1.transform.position + z;
        }

        if (zong_liang.npc_box_int == 2)
        {
            transform.position = box2.transform.position + z;
        }
        if (zong_liang.npc_box_int == 3)
        {
            transform.position = box3.transform.position + z;
        }
        if (zong_liang.npc_box_int == 4)
        {
            transform.position = box4.transform.position + z;
        }

    }
}
