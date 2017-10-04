using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : jiagou {
    private Vector3 mouseworldpos = new Vector3();
    private Vector3 playerworldpos = new Vector3();
    public float speed = 20f;
    void Update () {
        playermove();
	}   
    public void playermove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseworldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            playerworldpos = GetComponent<Transform>().position;
            print(mouseworldpos);
            print(playerworldpos);
            if (mouseworldpos.x > playerworldpos.x)
            {
                GetComponent<Transform>().Translate(speed * Time.deltaTime, 0, 0);
            }
            if(mouseworldpos.x < playerworldpos.x)
            {
                GetComponent<Transform>().Translate(-speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
