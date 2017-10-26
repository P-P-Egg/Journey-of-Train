using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jubao : MonoBehaviour {
    public GameObject[] jubaowupin = new GameObject[9];//举报物品
    private Vector3 originscale;
    private float xmax;
    private float ymax;
    private Vector3 origintext;//举报信息初始位置
    private Vector3 nexttext;//下一页位置
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
        origintext = GameObject.FindWithTag("jubaoxinxi").transform.position;
        nexttext = new Vector3(origintext.x, origintext.y, origintext.z + 0.2f);
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
                    GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text += "举报成功\n";
                    GameObject.Find("jubaoscripts").GetComponent<jubaoscripts>().wrapcount++;
                }
                else
                {
                    GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text += "举报失败\n";
                    GameObject.Find("jubaoscripts").GetComponent<jubaoscripts>().wrapcount++;
                }
                jubaowu.GetComponent<timepiece>().isjubao = true;
            }
        }
        NewText();
    }
    private void OnMouseUp()
    {
        transform.localScale = change;
    }
    private void NewText()
    {
        if (GameObject.Find("jubaoscripts").GetComponent<jubaoscripts>().wrapcount >= 5)
        {
            Instantiate(GameObject.FindWithTag("jubaoxinxi"), nexttext, Quaternion.identity);//复制物体
            GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text = "";
        }
    }

}
