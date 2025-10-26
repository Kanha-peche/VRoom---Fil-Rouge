using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

[CreateAssetMenu]
public class ObjectDBSO : ScriptableObject
{
    public List<ObjectData> objectData;
}


[Serializable]
public class ObjectData
{
    [field: SerializeField]
    // name for object
    public string Name {  get; private set; } //to prevent other objects modifying them
    [field: SerializeField]
    //unique id for object
    public int ID { get; private set; }
    [field: SerializeField]
    //to define the size in tiles of the object
    public Vector2Int Size { get; private set; } = Vector2Int.one;
    [field: SerializeField]
    //the references of the prefab 
    public GameObject Prefab { get; private set; }
}