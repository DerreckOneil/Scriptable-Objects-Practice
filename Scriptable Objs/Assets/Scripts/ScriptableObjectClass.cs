using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Inventory/List", order = 1)]
public class ScriptableObjectClass : ScriptableObject
{
    
    public string objName = "New Obj";
    public bool colorIsRandom = false;
    public Color objColor = Color.black;
    public Vector3[] spawnPoints;
}
