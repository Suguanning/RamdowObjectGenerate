using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private ItemTemplateSO itemTemplateSO;
    [SerializeField] private Transform itemTemplateParrent;
    [SerializeField] ObjectGen objectGen;
    [SerializeField] Transform container;
    private ItemTemplate itemTemplate;
    public bool enable;
    // Start is called before the first frame update
    void Start()
    {
        //itemTemplate.gameObject.SetActive(false);
        canvas.gameObject.SetActive(false);
        objectGen.OnObjectCreate += ObjectGen_OnObjectCreate;
        itemTemplate = itemTemplateSO.prefab;
    }

    private void ObjectGen_OnObjectCreate(object sender, ObjectGen.ObjectCreateArg e)
    {
       
        ItemTemplate item = Instantiate(itemTemplate, itemTemplateParrent);
        item.SetName(e.transform.name);
        item.SetPos(e.transform.GetComponent<RamObj>().transform.position);
        item.SetObj(e.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            enable = !enable;
            canvas.gameObject.SetActive(enable);
        }
        
    }

}
