using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newnpc : MonoBehaviour {

    private float speed;

    private Rigidbody2D rg_2d;

	// Use this for initialization
	void Start () {
        rg_2d = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        an_jian();

    }

    void an_jian()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rg_2d.AddForce(new Vector2(0,15));
        }

        if (Input.GetKey(KeyCode.S))
        {
            rg_2d.AddForce(new Vector2(0, -5));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rg_2d.AddForce(new Vector2(-10, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rg_2d.AddForce(new Vector2(10, 0));
        }
    }


}
