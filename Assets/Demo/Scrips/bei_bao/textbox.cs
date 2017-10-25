using UnityEngine;

using System.Collections;

using UnityEngine.UI;

public class textalen : MonoBehaviour
{
    private Text Textshow;//用来显示的TEXT
    string Content_Text;//文字内容
    public GameObject go;//传入文字的物体
    int Rowindex = 1;//第几行
    private int wordNumber = 13;//每行显示字数          

    void Start () {
        Textshow = this.GetComponent<Text>();
        Textshow.GetComponent<RectTransform>().sizeDelta = new  Vector2(390f, 40 * Rowindex);
    }

    void Update()
    {
        Content_Text = go.GetComponent<Text>().text;//获取文字内容
        Textshow.text = "<size=30>"+ Content_Text + "</size>";//设定文字大小
        if(Content_Text.Length > wordNumber * Rowindex)//当文字的长度大于每行text限定的字数
        {
            Rowindex = Content_Text.Length / wordNumber;//判断文字需要几行
            Debug.Log("多少行？？？？" + Rowindex);
            Textshow.GetComponent<RectTransform>().sizeDelta = new Vector2(390f, 40 * Rowindex);//将Text的高度变成文字需求的高度
        }
    }
}
