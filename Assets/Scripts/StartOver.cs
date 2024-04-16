using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOver : MonoBehaviour
{
    public GameObject line;
    public GameObject ingredient;
    public GameObject exp;
    public void clear()
    {
        GameObject[] rootObjs = SceneManager.GetSceneByName("Drawing").GetRootGameObjects();
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Drawing"));
        foreach (GameObject obj in rootObjs)
        {
            if (obj.tag == "line" || obj.tag=="ingredient")
            {
                Destroy(obj);
            }
        }

        exp.SetActive(false);
        CollisionCounter.currentCollisionCount = 0;
    }
}
