using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameGrade
{
    EASY,
    NORMAL,
    DIFFICULT
}
public enum ControlType
{
    KEYBOARD,
    TOUCH,
    MOUSE
}
public class GameSetting : MonoBehaviour {

    public  float volume = 1;
    public  GameGrade grade = GameGrade.NORMAL;
    public  ControlType controlType = ControlType.KEYBOARD;
    public  bool isFullScreen = false;


    public TweenPosition startPanelTween;
    public TweenPosition OptionPanelTween;

    public void OnVolumeChanged()
    {
        print("OnVolumeChanged:"+ UIProgressBar.current.value);
        volume = UIProgressBar.current.value;
        //volume= UIProgressBar.current.value;
    }
    public void OnGameGradeChanged()
    {
        print("OnGameGradeChanged:"+ UIPopupList.current.value);
        switch (UIPopupList.current.value)
        {
            case "一般":
                grade = GameGrade.NORMAL;
                break;
            case "简单":
                grade = GameGrade.EASY;
                break;
            case "困难":
                grade = GameGrade.DIFFICULT;
                break;
        }
    }
    public void OnControlTypeChanged()
    {
        print("OnControlTypeChanged:"+ UIPopupList.current.value);
        switch (UIPopupList.current.value)
        {
            case "键盘":
                controlType = ControlType.KEYBOARD;
                break;
            case "鼠标":
                controlType = ControlType.MOUSE;
                break;
            case "触控":
                controlType = ControlType.TOUCH;
                break;
        }
    }
    public void OnIsFullscreenChanged()
    {
        print("OnIsFullscreenChanged"+ UIToggle.current.value);
        isFullScreen = UIToggle.current.value;
    }

    public void OnOptionButtonClick()
    {
        startPanelTween.PlayForward();
        OptionPanelTween.PlayForward();
    }
    public void OnCompetedButton()
    {
        startPanelTween.PlayReverse();
        OptionPanelTween.PlayReverse();
    }
}
