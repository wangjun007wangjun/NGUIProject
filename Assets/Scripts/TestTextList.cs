using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTextList : MonoBehaviour {

    private int number;
    private UITextList textList;
	void Awake () {
        textList = GetComponent<UITextList>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1))
        {
            textList.Add("www.wangjunedu.com" + number++);
        }
	}
}
