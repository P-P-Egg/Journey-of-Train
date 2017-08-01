using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public struct SaveData
{
    public bool iscounting;                                             //时间增加
    public string time;                                                 //存档时间
    public int millisecond;
    public int second;
    public int minute;
    public int hour;
    public string name;                                                 //管卡名字
    public float money;                                                 //金钱
    public Vector3 PlayerLocation;                                      //玩家位置
}


[System.Serializable]
public static class SaveLoad {

    public static SaveData[] savedatas = new SaveData[10];
    public static SaveData currentgame;
    static void Save()
    {
        BinarySerializationTool.Save(savedatas, "AV.mp4");
    }
    static void Load()
    {
        BinarySerializationTool.Load(savedatas, "Av.mp4");
    }
}
