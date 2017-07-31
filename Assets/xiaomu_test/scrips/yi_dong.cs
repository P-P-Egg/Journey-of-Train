using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yi_dong : MonoBehaviour {

    public KeyCode leftKey;
    public KeyCode rightKey;
    public float speed = 4;

    private Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(leftKey))
        {
            rigidbody2D.velocity = new Vector2(-speed, 0);
        }
        else if (Input.GetKey(rightKey))
        {
            rigidbody2D.velocity = new Vector2(speed, 0);
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        }
    }
}
