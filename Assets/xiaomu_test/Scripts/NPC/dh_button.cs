using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class dh_button : MonoBehaviour
{
    public static bool dui_hua_next = false;
    public static bool dui_hua_kuang_end = false;

    dui_hua duihua = new dui_hua();

    void Start()
    {


    }


    void Update()
    {

    }

    public void OnbuttonDown() //点击对话框，进行下一句，或者退出
    {
        if (dui_hua_kuang_end)
        {
            dui_hua.Dui_hua_image.enabled = false;
            dui_hua.Dui_hua_text.enabled = false;

            dui_hua_kuang_end = false;

        }


        if (dui_hua_next)
        {
            duihua.npc_dui_hua();        

            if (dui_hua_kuang_end)
            {
                dui_hua_next = false;
            }

        }

    }
}
