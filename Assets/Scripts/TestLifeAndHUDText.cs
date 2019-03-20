using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLifeAndHUDText : MonoBehaviour {

    private HUDText hUDText;
    private UISlider slider;

    void Start()
    {
        hUDText = this.GetComponent<HUDText>();
        slider = GameObject.Find("LifeBar").GetComponent<UISlider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float sliderValue = slider.value;
            hUDText.Add(-10, Color.red, 1);
            //          显示的文字，颜色，停留时间
            slider.value = sliderValue - 0.1f;
        }
        if (Input.GetMouseButtonDown(1))
        {
            float sliderValue = slider.value;
            hUDText.Add(+10, Color.green, 1);
            //          显示的文字，颜色，停留时间
            slider.value = sliderValue + 0.1f;

        }
    }
}
