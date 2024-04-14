using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonCheck : MonoBehaviour
{
    [SerializeField] Recipe recipe;
    [SerializeField] Pentagram heartPentagram;
    [SerializeField] Pentagram squarePentagram;
    [SerializeField] Pentagram trianglePentagram;
    [SerializeField] int messUps=0;
    [SerializeField] int collisionCount;
    [SerializeField] SnapOn snapOn1;
    [SerializeField] SnapOn snapOn2;
    [SerializeField] SnapOn snapOn3;
    [SerializeField] SnapOn snapOn4;

    string[][] summonIngredients = { new string[] { "Scorpion Tail", "Devil's Horn" }, new string[] { "Bloody Heart", "Rose Petals" }, new string[] { "Grave Dirt", "Mandrake Root" } };

    private void Start()
    {
        

    }
    public void checkSummon()
    {
        Debug.Log("start check");
        if (heartPentagram.isActiveAndEnabled && heartPentagram.collisionCounter > 0)
        {
            Debug.Log("Summoning failed");

        } else if (trianglePentagram.isActiveAndEnabled && trianglePentagram.collisionCounter > 0){
       
            Debug.Log("Summoning failed");

        }else if(squarePentagram.isActiveAndEnabled && squarePentagram.collisionCounter > 0)
        {
            Debug.Log("Summoning failed");
        }

        int idCurrentRecipe;

        switch (recipe.currentRecipe)
        {
            case "imp": idCurrentRecipe = 0;
                break;
            case "succubus": idCurrentRecipe= 1;
                break;
            case "golem": idCurrentRecipe = 2;
                break;
        }

        for(int i=0; i<5; i++)
        {

        }

    }
}
