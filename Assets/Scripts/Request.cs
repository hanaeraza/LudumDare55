using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Request 
{

    [SerializeField] public string requestText;
    [SerializeField] public bool fulfilled = false;
    [SerializeField] public bool correctlyFulfilled = false;
    [SerializeField] public bool accepted = false;
    [SerializeField] public string[] correctRecipes;
    // Start is called before the first frame update

    public Request()
    {
        this.requestText = "";
        this.correctRecipes = null;
    }
    public Request(string requestText, string[] correctRecipes)
    {
        this.requestText = requestText;
        this.correctRecipes = correctRecipes;
    }

    public Request(string requestText, bool fulfilled, bool correctlyFulfilled, string[] correctRecipes)
    {
        this.requestText = requestText;
        this.fulfilled = fulfilled;
        this.correctlyFulfilled = correctlyFulfilled;
        this.correctRecipes = correctRecipes;
    }
}
