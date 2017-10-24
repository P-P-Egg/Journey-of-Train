using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk_zhujue : MonoBehaviour {

    private TextMesh zhujue_text;


    void Start()
    {
        zhujue_text = gameObject.GetComponentInChildren<TextMesh>();
    }

    // Update is called once per frame
    void Update () {
        xiao_hui();
        fuzhi();
    }

    void xiao_hui() //自动销毁自己
    {
        Destroy(gameObject, 3);

    }

    void OnDestroy() //销毁时
    {
        
    }

    void fuzhi() //给TEXT赋值
    {
        zhujue_text.text = "检查行李";
    }
}
