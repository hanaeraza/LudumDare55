using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Requests List")]
public class Requests : ScriptableObject
{
    [SerializeField]
    public Request[] requests;
}
