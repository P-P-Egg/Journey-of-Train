﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclicknewgame : MonoBehaviour {

	public void OnClick()
    {
        SceneManager.LoadScene("scen_game");
    }
}
