﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class BinarySerializationTool {
    

    public static void Save<T>(T obj,string name)
    {
        FileStream SaveData = new FileStream(name, FileMode.OpenOrCreate);
        if (SaveData != null)
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(SaveData, obj);
        }
        SaveData.Close();
    }
    public static void Load<T>(T obj,string name)
    {
        FileStream SaveData = new FileStream(name, FileMode.Open);
        if (SaveData!=null)
        {
            BinaryFormatter bf = new BinaryFormatter();
            obj = (T)bf.Deserialize(SaveData);
        }
        SaveData.Close();
    }
    
}
