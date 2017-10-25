using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpackcancel : MonoBehaviour {

    private void OnMouseDown()
    {
        GameObject.FindWithTag("backpack").SetActive(false);
        Time.timeScale = 1;
    }
}
