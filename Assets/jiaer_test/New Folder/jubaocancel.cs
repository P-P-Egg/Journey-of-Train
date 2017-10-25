using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jubaocancel : MonoBehaviour {
    private Vector3 originscale;
    public float xmax;
    public float ymax;
    // Use this for initialization
    void Start()
    {
        originscale = transform.localScale;
        xmax = 1.5f * transform.localScale.x;
        ymax = 1.5f * transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseOver()
    {
        Vector3 change = new Vector3(20*Time.deltaTime, 20*Time.deltaTime, 0);
        if (transform.localScale.x <= xmax && transform.localScale.y < ymax)
        {
            transform.localScale += change;
        }
    }
    private void OnMouseExit()
    {
        transform.localScale = originscale;
    }
    private void OnMouseDown()
    {
        GameObject.Find("Canvas/jubaoxin").SetActive(false);
    }
}
