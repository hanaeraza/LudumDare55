using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonCheck : MonoBehaviour
{
    [SerializeField] GameObject heartPentagram;
    [SerializeField] int messUps=0;
    [SerializeField] int collisionCount;

    private void Start()
    {
        heartPentagram=GetComponent<GameObject>();

    }
    public void checkSummon()
    {
        Debug.Log("start check");
       
        
    }
}
