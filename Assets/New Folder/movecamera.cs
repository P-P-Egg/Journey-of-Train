using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour {
    private Transform player;
    private Vector3 offsetStation;
    public Vector3 empty;
    void Awake()
    {
        player = GameObject.Find("Sphere/GameObject").transform;
        transform.Translate(player.position);
        offsetStation = transform.position - player.position;
        empty = GameObject.Find("GameObject").transform.position;
    }
    void Update()
    {
        empty = GameObject.Find("GameObject").transform.position;
        transform.position = offsetStation + player.position;
    }
}
