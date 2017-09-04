using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//这是所有对话的bool值
public class bool_dui_hua : MonoBehaviour {


    public static bool[] kai_guan_dui_hua = new bool[10000];

    public static void dh_bool_10000()
    {
        kai_guan_dui_hua[0] = true;
    }

    public static void dh_bool_10001()
    {
        kai_guan_dui_hua[1] = true;
    }


}
