using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclickreturn : MonoBehaviour {
    public void OnreClicked()
    {
        SceneManager.LoadScene("scene_begin");
    }    
}
