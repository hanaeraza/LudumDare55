using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Requests List")]
public class Requests : ScriptableObject
{
    [SerializeField]
    public Request[] requests;

    [SerializeField]
    public static Request currentRequest;
    [SerializeField]
    public  Request currentRequest1;
}
