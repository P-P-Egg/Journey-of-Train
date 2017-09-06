﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour {
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
        if (cameramove.x > -8.26f && cameramove.x < 8.26f) 
        {
            transform.position = offsetStation + player.position;
        }
    }
}
