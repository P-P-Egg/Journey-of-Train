using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lie_che_audio : MonoBehaviour {

    private float daltatime;

    public AudioSource AS; //自身

    public AudioClip 列车循环;
    public AudioClip 列车启动;

    
    float 音量大小 = 0.5f;
    float 播放速度 = 1;


    private bool qi_dong_bool; //启动bool
    private bool qi_dong2_bool;

    private bool xun_huan_bool; //循环bool
    private bool xun_huan2_bool;

    void Start () {
		
	}
	
	
	void Update () {
        lie_che_qi_dong();
        if (xun_huan_bool)
        {
            lie_che_xun_huan();
        }


    }


    void lie_che_qi_dong() // 列车启动的声音
    {
        
        if(qi_dong_bool != true)
        {
            AS.Play();
            qi_dong_bool = true;
            qi_dong2_bool = true;
        }

        if (qi_dong2_bool)
        {
            daltatime += Time.deltaTime;
            if (daltatime > 7)
            {
                AS.Stop(); //停止播放
                qi_dong2_bool = false;
                xun_huan_bool = true;
            }
        }

        
    }
        
       

    void lie_che_xun_huan() //列车循环的声音
    {
        AS.clip = 列车循环;

        daltatime += Time.deltaTime; 
        if(daltatime > 3) //每三秒随机变化音效
        {
            音量大小 = Random.Range(0.15f, 0.3f);
            播放速度 = Random.Range(1f, 1.25f);
            daltatime = 0;
        }      
        AS.volume = 音量大小;
     
        AS.pitch = 播放速度;


        if (xun_huan2_bool != true) //播放声音
        {
            AS.Play();
            xun_huan2_bool = true;
        }
        

        AS.loop = true; //循环
        
    }
}
