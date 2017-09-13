using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ID10001 : jiagou {
    private dialoguedata t1 = new dialoguedata();
    private int i = 0;
    private int a = 0, b = 0;
    private void Start()
    {
        string dirpath = Application.dataPath + "/Save";
        string filename = dirpath + "/GameData.sav";
        dialoguedata t1 = (dialoguedata)IOHelper.GetData(filename, typeof(dialoguedata));
    }
    private void Update()
    { 
        showDialoguesecond(t1.dia[1], GameObject.Find("Canvas/Text"));
    }
    private void OnMouseDown()
    {
        showDialoguefirst(t1.dia[0], GameObject.Find("Canvas/Text"));
        t1.dia[0].isTalk = true;        
    }
}
