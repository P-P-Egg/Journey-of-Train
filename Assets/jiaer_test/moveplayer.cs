using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour {

	void Update () {
        playermove();
	}
    public float speed = 20f;
    public void playermove()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.right * -speed * Time.deltaTime); 
            
        }
    }
}
