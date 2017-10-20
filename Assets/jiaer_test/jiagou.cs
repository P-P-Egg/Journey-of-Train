using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jiagou : MonoBehaviour {
    void Start()
    {
        dialoguedata dia=new dialoguedata();        
        string dirpath = Application.dataPath + "/Save";
        IOHelper.CreateDirectory(dirpath);
        string filename = dirpath + "/GameData.sav";
        IOHelper.SetData(filename, dia);
    }
    public class dialoguedata
    {
        public dialogue[] dia = {
            new dialogue { NPC = "jiaer", ID = 10000, isTalk = false, canTalk=true, dialoguecontent = "hello my name is jiaer" },
            new dialogue { NPC = "jiaer", ID = 10001, isTalk = false, canTalk=false, dialoguecontent = "I want to make friend with you" }                                   
        };
    }
    public struct  dialogue
    {
        public string NPC;
        public int  ID;
        public bool canTalk;
        public bool isTalk;
        public string dialoguecontent;           
    }
    public void  showDialoguefirst(dialogue example,GameObject A)
    {
        if (example.canTalk == true)
        {
            A.GetComponent<Text>().text = example.dialoguecontent;
            example.isTalk = true;
        }       
    }
    public void showDialoguesecond(dialogue example,GameObject A)
    {
        if (example.canTalk == true && Input.GetMouseButtonDown(0))
        {
            A.GetComponent<Text>().text = example.dialoguecontent;
            example.canTalk = true;
        }
        
    }
    public void Choose(dialogue example1,dialogue example2)
    {
        if (example1.isTalk == true)
        {
            example2.isTalk = true;
        }
    }

    public enum attribute { dia,cho}//对话或选项
}


