using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jubaoscripts : MonoBehaviour {

    public int wrapcount = 0;//换行次数
    private Vector3 originpos;
    private Vector3 newpos;
    public int recodecount;
    public GameObject[] textrecode;
    private void Update()
    {
        originpos = GameObject.FindWithTag("jubaoxinxi").transform.position;
        newpos = new Vector3(originpos.x, originpos.y, -4.9f);
        if (wrapcount > 3)
        {
            //Instantiate(GameObject.FindWithTag("jubaoxinxi"),newpos,Quaternion.identity);
            textrecode[recodecount].GetComponent<TextMesh>().text = GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text;
            print(textrecode[recodecount].GetComponent<TextMesh>().text);
            wrapcount = 0;
            GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text = "";
            recodecount++;
            print("wozhixingle");
            print(textrecode[recodecount-1].GetComponent<TextMesh>().text);
        }
    }
    

}
