using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ObjectGen : MonoBehaviour
{
    public static ObjectGen instance { get; set; }
    [SerializeField] ObjectPoolSO objectPool;
    [SerializeField] Transform spawnPoint;
    public List<Transform> objectExit = new List<Transform>();
    public event EventHandler<ObjectCreateArg> OnObjectCreate;
    private void Awake()
    {
        instance = this;
    }
    public class ObjectCreateArg
    {
        public Transform transform;
    }
    private int objectMaxCnt;
    private void Start()
    {
        objectMaxCnt = objectPool.prefabs.Length;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            int randomNumber = UnityEngine.Random.Range(0, objectMaxCnt);
            Transform ObjTransform = Instantiate(objectPool.prefabs[randomNumber], spawnPoint.position,spawnPoint.rotation);
            objectExit.Add(ObjTransform);
            OnObjectCreate?.Invoke(this, new ObjectCreateArg { transform = ObjTransform.GetChild(0) });
        }
    }
}
