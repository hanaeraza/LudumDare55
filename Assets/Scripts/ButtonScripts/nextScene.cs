using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    [SerializeField] string sceneName = "drawing";
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
}
