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
        // 检测射线是否与物体相交
        if (Physics.Raycast(ray, out hit))
        {
            // 如果射线与物体相交，并且该物体具有选中脚本
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
