using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatSystem : MonoBehaviour {

    // Use this for initialization
    private UITextList textList;//显示所有的聊天信息
    private UIInput InputuILabel;//输入框

    private string chatString;

    private string[] names = new string[3]
    {
        "Wangjun","系统","韩梅梅"
    };
    void Awake()
    {
        textList =GameObject.Find("ChatPanelLable").GetComponent<UITextList>();
        InputuILabel = GameObject.Find("ChatInputFiled").GetComponent<UIInput>();
       // chatString = textList.scrollValue
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	public void SendButtonClick()
    {
        string currentName = names[Random.Range(0, 3)];
        chatString =InputuILabel.value;
        textList.Add(currentName+":"+ chatString);
        InputuILabel.value = "";
    }
}
