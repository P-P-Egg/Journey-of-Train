using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timetest : jiagou {
    public float times;
    public int a = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        times = Time.time;
        timetoday();
    }
    void timetoday()
    {
        while(times - (int)times == 0)
        {
            a++;
            Debug.Log(a);
        }
    }

}
