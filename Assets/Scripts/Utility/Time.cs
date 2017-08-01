using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour {

    
    private void FixedUpdate()
    {
        if(SaveLoad.currentgame.iscounting)
            if (++SaveLoad.currentgame.millisecond == 100)
                if (++SaveLoad.currentgame.second == 60)
                    if (++SaveLoad.currentgame.minute == 60)
                        ++SaveLoad.currentgame.hour;
    }
}
