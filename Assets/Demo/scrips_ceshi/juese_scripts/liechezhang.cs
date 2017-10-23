using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liechezhang : MonoBehaviour {
    private Vector3 zhujue_pos = new Vector3();
    private Vector3 npc_pos = new Vector3();
    private Vector3 zhujue_sca = new Vector3();
    private Vector3 npc_sca = new Vector3();
    private GameObject zhujue;
    private void Start()
    {
        zhujue = GameObject.FindWithTag("Player");
    }
    private void Update()
    {
        
        zhujue_pos = zhujue.transform.position;
        npc_pos = transform.position;
        zhujue_sca = zhujue.transform.localScale;
        npc_sca = transform.localScale;
    }
    private void OnMouseDown()
    {
        if (zhujue_pos.x > npc_pos.x)
        {
            zhujue.transform.localScale = new Vector3(-zhujue_sca.x, zhujue_sca.y, zhujue_sca.z);
        }
        Time.timeScale = 0;
    }
}
