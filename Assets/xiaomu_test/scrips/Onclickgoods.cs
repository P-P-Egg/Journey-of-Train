using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    //public bool goods = false;
    //public bool npc = false;

    public string goodsName;
    public string npcName;

    void Start () {
		
	}

	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            //还需要获取主角位置

            Speak speak = new Speak();
            GameGoods gamegoods = new GameGoods();

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // if(hit.transform.position.x - 主角位置的x轴 <= 2）如果足够接近物体，就触发物体效果
                if(hit.transform.tag == "goods")
                {
                    goodsName = hit.transform.name;

                    gamegoods.Goods(goodsName); //这放执行物体代码的函数，参数就是goodsName
                }
                if(hit.transform.tag == "npc")
                {
                    npcName = hit.transform.name;

                    speak.NpcSpeak(npcName); //这放执行npc对话代码的函数，参数就是npcName
                }
            }
        }

    }
}
