using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonUI : MonoBehaviour
{
    public Button myButton;

    void Start()
    {
        // ���ð�ť�ĵ���¼��������
        myButton.onClick.AddListener(ButtonClicked);
    }

    void ButtonClicked()
    {
        // ��ť����¼��Ĵ����߼�
        Debug.Log("Button Clicked!");
    }
}
