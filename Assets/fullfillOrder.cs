using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class fullfillOrder : MonoBehaviour
{

    [SerializeField] Recipe currentRecipe;
    [SerializeField] Request currentRequest;
    [SerializeField] GameObject orderUI;
    bool correctRecipe = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!currentRecipe.isCompleted)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }
    }
    public void checkout()
    {
        if (currentRecipe.isCompleted)
        {
            
            for(int i = 0; i < Requests.currentRequest.correctRecipes.Length; i++)
            {
                if (Requests.currentRequest.correctRecipes[i] == currentRecipe.currentRecipe)
                {
                    correctRecipe = true;
                }
            }

            if (!currentRecipe.succeded)
            {


            } else if(correctRecipe ) {

                Requests.currentRequest.fulfilled = true;
                currentRecipe.isCompleted = false;
                currentRecipe.succeded = false;
            }
        } 
    }

}
