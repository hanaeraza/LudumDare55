using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject bloodyHeartPrefab;
    public GameObject rosePetalsPrefab;
    public GameObject scorpionTailPrefab;
    public GameObject devilsHornPrefab;
    public GameObject graveDirtPrefab;
    public GameObject mandrakeRootPrefab;
    

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
    public void InstantiateScorpionTail()
    {

        Debug.Log("ScorpionTail instantiated");
        Instantiate(scorpionTailPrefab);
    }
    public void InstantiateDevilsHorn()
    {

        Debug.Log("Devil's Horn instantiated");
        Instantiate(devilsHornPrefab);
    }
    public void InstantiateGraveDirt()
    {

        Debug.Log("Grave dirt instantiated");
        Instantiate(graveDirtPrefab);
    }
    public void InstantiateMandrakeRoot()
    {

        Debug.Log("Mandrake root instantiated");
        Instantiate(mandrakeRootPrefab);
    }
}
