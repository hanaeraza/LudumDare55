using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonCheck : MonoBehaviour
{
    [SerializeField] Pentagram heartPentagram;
    [SerializeField] Pentagram squarePentagram;
    [SerializeField] Pentagram trianglePentagram;
    [SerializeField] int messUps=0;
    [SerializeField] int collisionCount;

    private void Start()
    {
        

    }
    public void checkSummon()
    {
        Debug.Log("start check");
        if (heartPentagram.isActiveAndEnabled && heartPentagram.collisionCounter > 0)
        {
            Debug.Log("Summoning failed");
        } else if (trianglePentagram.isActiveAndEnabled && trianglePentagram.collisionCounter > 0){
       
            Debug.Log("Summoning failed");

        }else if(squarePentagram.isActiveAndEnabled && squarePentagram.collisionCounter > 0)
        {
            Debug.Log("Summoning failed");
        }

    }
}
