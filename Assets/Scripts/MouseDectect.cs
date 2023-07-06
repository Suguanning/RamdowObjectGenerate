using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MouseDectect : MonoBehaviour
{
    private RamObj ramObjSelected;
    public UICtrl uICtrl;
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (uICtrl.enable)
            return;
        // ��������Ƿ��������ཻ
        if (Physics.Raycast(ray, out hit))
        {
            // ��������������ཻ�����Ҹ��������ѡ�нű�
            if (hit.transform.TryGetComponent<RamObj>(out RamObj ramObj))
            {
                if(ramObjSelected != null)
                    ramObjSelected.Unselected();
                ramObjSelected = ramObj;
                ramObjSelected.Selected();
            }
            else
            {
                if (ramObjSelected != null)
                {
                    ramObjSelected.Unselected();
                    ramObjSelected = null;
                }
            }
        }
        else
        {
            if (ramObjSelected != null)
            {
                ramObjSelected.Unselected();
                ramObjSelected = null;
            }

        }
    }
    
}
