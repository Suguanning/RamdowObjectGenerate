using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonUI : MonoBehaviour
{
    public Button myButton;

    void Start()
    {
        // 设置按钮的点击事件处理程序
        myButton.onClick.AddListener(ButtonClicked);
    }

    void ButtonClicked()
    {
        // 按钮点击事件的处理逻辑
        Debug.Log("Button Clicked!");
    }
}
