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

    [SerializeField] bool summonSuccess;
    [SerializeField] GameObject explosion;
    [SerializeField] ParticleSystem particles;

    [SerializeField] Sprite golem;
    [SerializeField] Sprite imp;
    [SerializeField] Sprite succubus;

    string[][] summonIngredients = { new string[] { "Scorpion Tail(Clone)", "Devil's Horn(Clone)", null, null }, new string[] { "Bloody Heart(Clone)", "Rose Petals(Clone)", null, null }, new string[] { "Grave Dirt(Clone)", "Mandrake Root(Clone)", null, null } };
    Sprite[] demons = { };
    private void Start()
    {
        demons = new Sprite[] { imp, succubus, golem};
        summonSuccess = true;
        explosion.SetActive(false);

    }
    public void checkSummon()
    {
        SnapOn[] snapOns = {snapOn1, snapOn2, snapOn3, snapOn4 };
        Debug.Log("start check");
        if (heartPentagram.isActiveAndEnabled && heartPentagram.collisionCounter > 0)
        {
            Debug.Log("Summoning failed");
            summonSuccess = false;

        } else if (trianglePentagram.isActiveAndEnabled && trianglePentagram.collisionCounter > 0){
       
            Debug.Log("Summoning failed");
            summonSuccess = false;

        }
        else if(squarePentagram.isActiveAndEnabled && squarePentagram.collisionCounter > 0)
        {
            Debug.Log("Summoning failed");
            summonSuccess = false;
        }

        int idCurrentRecipe=-1;

        switch (recipe.currentRecipe)
        {
            case "Imp": idCurrentRecipe = 0;
                break;
            case "Succubus": idCurrentRecipe= 1;
                break;
            case "Golem": idCurrentRecipe = 2;
                break;
            
        }
        if (idCurrentRecipe >= 0)
        {


            for (int i = 0; i < 4; i++)
            {
                //Debug.Log(i);
                if (snapOns[i]?.currentObject?.name == null && summonIngredients[idCurrentRecipe][i] != null)
                {
                    Debug.Log("Summoning failed due to missing ingredients: " + snapOns[i]?.currentObject?.name + "!=" + summonIngredients[idCurrentRecipe][i]);
                    summonSuccess = false;
                }
                else if (snapOns[i]?.currentObject?.name != summonIngredients[idCurrentRecipe][i])
                {
                    Debug.Log("Summoning failed due to wrong ingredients" + snapOns[i]?.currentObject?.name + "!=" + summonIngredients[idCurrentRecipe][i]);
                    summonSuccess = false;
                }
            }
        }
        else
        {
            summonSuccess = false;
            Debug.Log("No summoning recipe was selected");

        }
        if (summonSuccess)
        {
            Debug.Log("Summoning Succeeded!");
            Instantiate(particles);
            Instantiate(demons[idCurrentRecipe]);
            recipe.succeded = true;
            recipe.isCompleted = true;
            
        }
        else
        {
            explosion.SetActive(true);
            recipe.isCompleted = true;
            recipe.succeded = false;
        }

    }
}
