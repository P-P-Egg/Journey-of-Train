using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public struct haha
{
    public string c;
}

[System.Serializable]
public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string c = "sjfioaoief";

        BinarySerializationTool.Save(c, "testsave");
        haha k = new haha();
        k.c = "kkkkkkk";
        BinarySerializationTool.Save(k, "ktest");
	}

}
