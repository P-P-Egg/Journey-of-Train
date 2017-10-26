using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jubao : MonoBehaviour {
    public GameObject[] jubaowupin = new GameObject[9];//举报物品
    private Vector3 originscale;
    private float xmax;
    private float ymax;
    private Vector3 change;


    // Use this for initialization
    void Start () {
        originscale = transform.localScale;
        xmax = 1.2f * transform.localScale.x;
        ymax = 1.2f * transform.localScale.y;
        change = new Vector3(xmax, ymax, 0);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    private void OnMouseEnter()
    {        
        if (transform.localScale.x <= xmax && transform.localScale.y < ymax)
        {
            transform.localScale = change;
        }
    }
    private void OnMouseExit()
    {
        transform.localScale = originscale;
    }

    private void OnMouseDown()
    {
        foreach (GameObject jubaowu in jubaowupin)
        {
            transform.localScale = originscale;

            if (jubaowu.GetComponent<timepiece>().canjubao&& !jubaowu.GetComponent<timepiece>().isjubao)
            {
                GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text += jubaowu.GetComponent<timepiece>().name + " ";
                if (jubaowu.GetComponent<timepiece>().rightjubao)
                {
                    GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text += "\n                              <color=#228B22>举报成功</color>\n";
                    GameObject.Find("jubaoscripts").GetComponent<jubaoscripts>().wrapcount++;
                }
                else
                {
                    GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text += "\n                              <color=#CD0000>举报失败</color>\n";
                    GameObject.Find("jubaoscripts").GetComponent<jubaoscripts>().wrapcount++;
                }
                jubaowu.GetComponent<timepiece>().isjubao = true;
            }
        }
    }
    private void OnMouseUp()
    {
        transform.localScale = change;
    }
}
