using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class RecipeLookup : MonoBehaviour
{
    public GameObject RecipeList;
    public GameObject RecipePage; 
    public TMP_Text summonTitle; 
    public TMP_Text summonDescription; 
    public GameObject summonCircleImage; 
    public GameObject[] ingredients; // All 4 slots for potential ingredients
    public Sprite[] circles; 

    public void LookupRecipe(int index) {
        string[] summonType = {"Imp", "Succubus", "Golem"}; 
        string[] summonDesc = {"A naughty little devil with a penchant for mischief", "A seductive she-demon that deals in love and companionship", "An earthen construct that's happy to guard and protect"}; 
        
        
        string[][] summonIngredients = { new string[] {"Scorpion Tail", "Devil's Horn"}, new string[] {"Bloody Heart", "Rose Petals"}, new string[] {"Grave Dirt", "Mandrake Root"}};
        string[] position = { "North", "East", "West", "South" };
        
        summonTitle.text = summonType[index]; 
        summonDescription.text = summonDesc[index]; 
        summonCircleImage.GetComponent<Image>().sprite = circles[index]; 

        // Ingredients
        int ingredientsNum = summonIngredients[index].Length;

        for (int i = 0; i < ingredientsNum; i++) {
            
            ingredients[i].GetComponent<TMP_Text>().text = position[i] + " - " + summonIngredients[index][i];
            ingredients[i].SetActive(true); 

        }

        RecipeList.SetActive(false);
        RecipePage.SetActive(true); 

    }

    public void GoBack() {
        RecipePage.SetActive(false);
        RecipeList.SetActive(true);
        
    }

}
