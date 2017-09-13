using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : jiagou{
    private Transform player;
    private Vector3 offsetStation;
    public Vector3 cameramove;
    void Awake()
    {
        player = GameObject.FindWithTag("player").transform;
        transform.position = new Vector3(-8.26f, 0, -10f);
        offsetStation = transform.position - player.position;        
    }
    void Update()
    {
        cameramove = GameObject.FindWithTag("player").transform.position;
        if (cameramove.x >= -7.0f && cameramove.x <= 7.0f) 
        {
            transform.position = offsetStation + player.position;
        }
    }
}
