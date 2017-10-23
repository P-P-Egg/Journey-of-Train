using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoague_ceshi : MonoBehaviour {
    
    private void OnMouseDown()
    {
        Time.timeScale = 0;
        GameObject.Find("dialogbox").transform.position = GameObject.FindWithTag("MainCamera").transform.position + new Vector3(0, 5.5f, 9.9f);
        GameObject.Find("Canvas/Text").GetComponent<Text>().text = "hello, my name is jiaer";

    }
}
