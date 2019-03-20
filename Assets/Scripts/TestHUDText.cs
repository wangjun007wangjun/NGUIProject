using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHUDText : MonoBehaviour {

    // Use this for initialization
    private HUDText hUDText;
	void Start () {
        hUDText = this.GetComponent<HUDText>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            hUDText.Add(-10, Color.red, 1);
            //          显示的文字，颜色，停留时间
        }
        if (Input.GetMouseButtonDown(1))
        {
            hUDText.Add(+10, Color.green, 1);
            //          显示的文字，颜色，停留时间
        }
    }
}
