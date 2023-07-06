using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamObj : MonoBehaviour
{
    [SerializeField] GameObject selectedVisual;
    [SerializeField] MouseDectect mouseDectect;
    // Start is called before the first frame update
    void Start()
    {
        selectedVisual.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Selected()
    {
        selectedVisual.SetActive(true);
    }
    public void Unselected()
    {
        selectedVisual.SetActive(false);
    }

}
