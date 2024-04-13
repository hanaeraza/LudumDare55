using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Request 
{

    [SerializeField] public string requestText;
    [SerializeField] bool fulfilled = false;
    [SerializeField] bool correctlyFulfilled = false;
    [SerializeField] public string[] correctRecipes;
    // Start is called before the first frame update

    public Request(string requestText, string[] correctRecipes)
    {
        this.requestText = requestText;
        this.correctRecipes = correctRecipes;
    }

}
