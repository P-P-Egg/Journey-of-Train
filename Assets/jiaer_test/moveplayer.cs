using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : jiagou {
    public GameObject dialoguebox;
    private Vector3 characterposition = new Vector3();
    private Vector3 mouseworldpos = new Vector3();
    private Vector3 playerworldpos = new Vector3();
    public float cpoffset=3.5f;
    public float speed = 20f;
    private void Start()
    {
        dialoguebox = GameObject.Find("Dialogue group");
        characterposition = this.GetComponent<Transform>().position;
    }
    void Update () {

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
    private void OnMouseDown()
    {
        dialoguebox.GetComponent<Transform>().position = characterposition;
        dialoguebox.GetComponent<Transform>().Translate(0,cpoffset,0);
    }
}
