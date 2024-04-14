using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonCheck : MonoBehaviour
{
    [SerializeField] GameObject StarPentagram;
    [SerializeField] int messUps=0;
    public void checkSummon()
    {
        Debug.Log("start check");
        Collider[] colliders = StarPentagram.GetComponentsInChildren<Collider>();
        for(int i = 0; i < colliders.Length; i++)
        {
            
        }
    }
}
