﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jubaoxin : MonoBehaviour {

	public void xiayi()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        Time.timeScale = 0;
    }
}
