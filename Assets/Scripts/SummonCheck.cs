using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonCheck : MonoBehaviour
{
    [SerializeField] Pentagram heartPentagram;
    [SerializeField] int messUps=0;
    [SerializeField] int collisionCount;

    private void Start()
    {
        

    }
    public void checkSummon()
    {
        Debug.Log("start check");
        if (heartPentagram.collisionCounter > 0)
        {
            Debug.Log("Summoning failed");
        }
        
    }
}
