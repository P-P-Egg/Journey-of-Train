using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jubao : MonoBehaviour {
    public GameObject[] jubaowupin = new GameObject[9];//举报物品
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
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
