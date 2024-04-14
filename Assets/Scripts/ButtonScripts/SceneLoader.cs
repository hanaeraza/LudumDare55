using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{


    [SerializeField] string sceneName = "customersTests";
    [SerializeField] string mainSceneName = "customersTests";
    [SerializeField] string secondarySceneName = "Drawing";
    [SerializeField] Button mainSceneButton;
    [SerializeField] GameObject mainSceneUI;
    [SerializeField] GameObject secondarySceneUI;
    [SerializeField] Scene secondaryScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentScene.currentScene == mainSceneName)
        {
            mainSceneButton.interactable = true;
            mainSceneUI?.SetActive(true);

        } 
    }

    public void loadAScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void unLoadScene()
    {
        secondarySceneUI.SetActive(false);
        CurrentScene.currentScene = mainSceneName;

    }

    public void mainSceneActivate()
    {
        GameObject[] rootObjs = SceneManager.GetSceneByName(secondarySceneName).GetRootGameObjects();
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(mainSceneName));
        foreach (GameObject obj in rootObjs)
            obj.SetActive(false);

        CurrentScene.currentScene = mainSceneName;
        AudioManager.Instance.PlayFrontMusic(); 

    }

    public void secondarySceneActivate()
    {
        mainSceneButton.interactable = false;
        mainSceneUI?.SetActive(false);
        GameObject[] rootObjs = SceneManager.GetSceneByName(secondarySceneName).GetRootGameObjects();
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(secondarySceneName));
        foreach (GameObject obj in rootObjs)
            obj.SetActive(true);

        CurrentScene.currentScene = secondarySceneName;
        AudioManager.Instance.PlayBackMusic(); 
    }

    public void loadASceneOntop()
    {

        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        CurrentScene.currentScene = sceneName;
    }

}
