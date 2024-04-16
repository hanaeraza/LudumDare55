using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "stats")]
public class TotalStats : ScriptableObject
{

    [SerializeField] public  int totalCustomers;
    [SerializeField] public int totalSuccessOrders;
    [SerializeField] public int totalBotchedOrders;
}
