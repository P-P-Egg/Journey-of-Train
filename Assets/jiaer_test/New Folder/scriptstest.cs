using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptstest : MonoBehaviour
{
    public  GameObject[] boxlights=new GameObject[9];
    private void Awake()
    {
        boxlights = GameObject.FindGameObjectsWithTag("boxlight");
    }
}
