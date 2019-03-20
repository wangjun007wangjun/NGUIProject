using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDragDropItem : UIDragDropItem {

    // Use this for initialization
    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);

        //进行自己的处理
        print(surface);
    }
}
