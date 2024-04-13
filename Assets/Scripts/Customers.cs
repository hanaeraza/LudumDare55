using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Customer List")]
public class Customers : ScriptableObject
{
    [SerializeField]
    public GameObject[] customers;
}
