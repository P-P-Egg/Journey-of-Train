using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jubaoscripts : MonoBehaviour {

    public int wrapcount = 0;//换行次数
    private Vector3 originpos;
    private Vector3 newpos;
    public List<TextMesh> textrecode;
    public int recodecount;
    private void Update()
    {
        originpos = GameObject.FindWithTag("jubaoxinxi").transform.position;
        newpos = new Vector3(originpos.x, originpos.y, -4.9f);
        if (wrapcount > 3)
        {
            //Instantiate(GameObject.FindWithTag("jubaoxinxi"),newpos,Quaternion.identity);
            textrecode.Add(GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>());
            print(textrecode[recodecount].text);
            GameObject.FindWithTag("jubaoxinxi").GetComponent<TextMesh>().text = "";
            wrapcount = 0;
            recodecount++;
            print("wozhixingle");
            print(textrecode[recodecount].text);
        }
    }
    

}
