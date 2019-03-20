using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knapsack_Item : UIDragDropItem {

    public UISprite sprite;
    public UILabel lable;
    private int count = 1;

    public void AddCount(int number=1)
    {
        count +=number;
        lable.text = count + "";
    }

    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);


        if (surface.tag=="Cell")
        {
            this.transform.parent = surface.transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if(surface.tag=="KnapsackItem")
        {
            Transform parent = surface.transform.parent;
            surface.transform.parent = this.transform.parent;
            surface.transform.localPosition = Vector3.zero;

            this.transform.parent = parent;
            this.transform.localPosition = Vector3.zero;
        }
    }
}
