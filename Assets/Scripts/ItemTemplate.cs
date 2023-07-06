using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ItemTemplate : MonoBehaviour
{
    [SerializeField] public TMP_Text posText;
    [SerializeField] public TMP_Text nameText;
    public Transform obj;
    public ObjectGen objectGen;
    private void Start()
    {
        objectGen = ObjectGen.instance;
    }
    private void Update()
    {
        SetPos(obj.position);
    }
    public void OnDeleteButtonHit()
    {
        Debug.Log("Delete");
        if(obj != null)
        {
            objectGen.objectExit.Remove(obj);
        }
        Destroy(obj.gameObject);
        Destroy(this.gameObject);
    }
    public void SetPos(Vector3 pos)
    {
        Debug.Log(pos);
        Vector3 vector = pos;
        string vectorString = vector.ToString();
        posText.text = vectorString;
    }
    public void SetName(string name)
    {
        nameText.text = name;
    }
    public void SetObj(Transform newObj)
    {
        obj = newObj;
    }
}
