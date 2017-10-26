using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcattribute : MonoBehaviour {
    public GameObject backpack;
    public int money;
    private void OnMouseDown()
    {
        backpack.SetActive(true);
        Vector3 newposition= GameObject.FindWithTag("MainCamera").transform.position;
        backpack.transform.position = new Vector3(newposition.x, newposition.y, -4.1f);
        Time.timeScale = 0;
    }
}
