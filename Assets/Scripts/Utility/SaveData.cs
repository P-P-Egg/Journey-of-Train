using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public struct SaveData
{
    public string time;                                                 //存档时间
    public string name;                                                 //管卡名字
    public float money;                                                 //金钱
    public Vector3 PlayerLocation;                                      //玩家位置
}


[System.Serializable]
public static class SaveLoad {

    public static SaveData[] savedatas = new SaveData[10];
    public static SaveData autosave = new SaveData();
    static void AutoSave()
    {
        BinarySerializationTool.Save(autosave, "AV.exe");
    }
    static void Save()
    {
        BinarySerializationTool.Save(savedatas, "AV.mp4");
    }
    static void Load()
    {
        BinarySerializationTool.Load(savedatas, "Av.mp4");
        BinarySerializationTool.Load(autosave, "AV.exe");
    }
}
