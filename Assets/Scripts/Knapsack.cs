using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knapsack : MonoBehaviour {

    // Use this for initialization
    public GameObject[] cells;

    public string[] equipmentsName;
    public GameObject item;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.X))
        {
            Pickup();
        }
	}

    public void Pickup()//捡起装备
    {
        int index = Random.Range(0, equipmentsName.Length);
        string name = equipmentsName[index];

        bool isFindSame = false;
        for (int i = 0; i < cells.Length; i++)
        {
            if (cells[i].transform.childCount > 0)//判断当前格子有没有物品
            {
                //如果有
                Knapsack_Item item = cells[i].GetComponentInChildren<Knapsack_Item>();
                //判断当前游戏格子内物品与我们拾取物品名字是否一样
                if (item.sprite.spriteName == name)
                {
                    isFindSame = true;
                    item.AddCount(1);
                    break;
                }
            }
        }
        if (isFindSame == false)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].transform.childCount == 0)
                {
                    //当前格子没有游戏物品
                    //直接添加捡起的物品
                    GameObject go = NGUITools.AddChild(cells[i], item);
                    go.GetComponent<UISprite>().spriteName = name;//装备在一个图集内，更改sprite的名字就可设置对应名字的图片
                    go.transform.localPosition = Vector3.zero;
                    break;
                }
            }
        }
    }
}
