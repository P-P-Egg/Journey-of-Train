using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpackcancel : MonoBehaviour {

    private Vector3 originscale;
    private Vector3 change;
    private float xmax;
    private float ymax;

    void Start()
    {
        originscale = transform.localScale;
        xmax = 1.2f * transform.localScale.x;
        ymax = 1.2f * transform.localScale.y;
        change = new Vector3(xmax, ymax, 0);
    }
    private void OnMouseEnter()
    {
        if (transform.localScale.x <= xmax && transform.localScale.y < ymax)
        {
            transform.localScale = change;
        }
    }

    private void OnMouseDown()
    {

        GameObject.FindWithTag("backpack").SetActive(false);

        manager.talk1_bool_js = true;
        manager2.talk2_bool_js = true;

        //Time.timeScale = 1;
    }

    private void OnMouseExit()
    {
        transform.localScale = originscale;
    }

}
