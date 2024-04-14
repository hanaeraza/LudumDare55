using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Day Counter")]
public class DayCounter : ScriptableObject
{
    [SerializeField]
    public int currentDay;
}
