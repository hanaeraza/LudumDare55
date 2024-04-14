using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Recipe")]
public class Recipe :ScriptableObject
{
    [SerializeField]
    public string currentRecipe;
    [SerializeField]
    public bool isCompleted;
    [SerializeField]
    public bool succeded;
}
