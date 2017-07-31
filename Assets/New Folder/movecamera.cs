using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour {
    private Transform player;
    private Vector3 offsetStation;
    public Vector3 cameramove;
    void Awake()
    {
        player = GameObject.FindWithTag("player").transform;
        transform.Translate(-5.82f,0.01f,0);
        offsetStation = transform.position - player.position;
        
    }
    void Update()
    {
        cameramove = GameObject.FindWithTag("player").transform.position;
        if (cameramove.x > -6 && cameramove.x < 6) 
        {
            transform.position = offsetStation + player.position;
        }
    }
}
