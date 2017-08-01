using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclicksettings : MonoBehaviour {
    public void OnseClicked()
    {
        SceneManager.LoadScene("scene_settings");
    }
}
