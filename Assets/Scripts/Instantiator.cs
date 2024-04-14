using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject bloodyHeartPrefab;
    public GameObject rosePetalsPrefab;

    public void InstantiateBloodyHeart()
    {
        
        Debug.Log("Bloody Heart instantiated");
        Instantiate(bloodyHeartPrefab);
    }
    public void InstantiateRosePetals()
    {

        Debug.Log("Rose Petals instantiated");
        Instantiate(rosePetalsPrefab);
    }
}
