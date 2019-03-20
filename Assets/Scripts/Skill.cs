using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour {

    // Use this for initialization
    public float coldTime = 2;

   
    private UISprite sprite;
    private bool isColding = false;



    private void Awake()
    {
        sprite = transform.Find("Sprite").GetComponent<UISprite>();
    }

	// Update is called once per frame
	 void Update () {
        //1.键盘
		if(Input.GetKeyDown(KeyCode.A)&&!isColding)
        {
            sprite.fillAmount = 1;
            isColding = true;
        }

        if(isColding)
        {
            sprite.fillAmount -= (1f / coldTime) * Time.deltaTime;
            if(sprite.fillAmount<=0.05f)
            {
                isColding = false;
                sprite.fillAmount = 0;
            }
        }
	}
    //触控
    public void skillButtonClick()
    {
        sprite.fillAmount = 1;
        isColding = true;

        if (isColding)
        {
            sprite.fillAmount -= (1f / coldTime) * Time.deltaTime;
            if (sprite.fillAmount <= 0.05f)
            {
                isColding = false;
                sprite.fillAmount = 0;
            }
        }
    }
}
