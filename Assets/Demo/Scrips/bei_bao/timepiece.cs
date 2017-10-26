using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//这是物品的脚本

public class timepiece : MonoBehaviour {
    public string information = "这是一个手表，是老王十分喜爱的东西";
    public bool canjubao;//是否可以举报，用于物品框的操作，和游戏逻辑无关
    public string npc;//拥有物品人
    public bool isjubao;//是否已经举报，用于物品框操作，和游戏逻辑无关
    public bool rightjubao;//举报该物品是否会成功
    public new string name;//物品名称
    public int jubaofankui;//举报后反馈，拿钱还是罚款
}
