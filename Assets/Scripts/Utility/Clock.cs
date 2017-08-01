using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour {
    Text ClockPanel;
    private void Start()
    {
        ClockPanel = GetComponent<Text>();
        SaveLoad.currentgame.iscounting = true;
    }
    private void FixedUpdate()
    {
        ClockPanel.text = SaveLoad.currentgame.hour + "/"+ SaveLoad.currentgame.minute+"/"+ SaveLoad.currentgame.second+"."+SaveLoad.currentgame.millisecond;
        if (SaveLoad.currentgame.iscounting)
            if (++SaveLoad.currentgame.millisecond == 100)
            {
                SaveLoad.currentgame.millisecond = 0;
                if (++SaveLoad.currentgame.second == 60)
                {
                    SaveLoad.currentgame.second = 0;
                    if (++SaveLoad.currentgame.minute == 60)
                    {
                        SaveLoad.currentgame.minute = 0;
                        ++SaveLoad.currentgame.hour;
                    }
                }
            }
    }
}
