using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CollisionCOunter")]

public class CollisionCounter : ScriptableObject
{
    [SerializeField] public static int currentCollisionCount;

    [SerializeField] public int otherCOunter;
}
