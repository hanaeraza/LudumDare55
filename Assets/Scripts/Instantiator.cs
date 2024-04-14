using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject bloodyHeartPrefab;

    public void InstantiateBloodyHeart()
    {
        Debug.Log("Bloody Heart instantiated");
        Instantiate(bloodyHeartPrefab);
    }
}
