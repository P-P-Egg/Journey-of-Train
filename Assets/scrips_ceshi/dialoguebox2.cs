using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoguebox2 : MonoBehaviour {

    private void OnMouseDown()
    {
        Time.timeScale = 1;
        transform.Translate(0, 20, 0);
        GameObject.Find("Canvas/Text").GetComponent<Text>().text = "";
    }
}
