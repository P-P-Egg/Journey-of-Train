using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bao_zhi_animator : MonoBehaviour {

    public static bool bao_zhi_animator_bool; //是否开启

    public static bool bao_zhi_guan_bool = true; //关报纸


 
    void Start () {
       
    }
	
	void Update () {
        if (bao_zhi_animator_bool)
        {
            transform.position = new Vector3(25.55f, 0.2f, -5f);

          

            bao_zhi_animator_bool = false;
        }

        if (bao_zhi_guan_bool)
        {
            transform.position = new Vector3(50f, 21.3f, -5f);

            bao_zhi_guan_bool = false;
        }
      

    }
}
