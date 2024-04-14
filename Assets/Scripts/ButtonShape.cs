using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShape : MonoBehaviour
{
    [SerializeField] Recipe recipe;
    [SerializeField] GameObject enabledPentagram;
    [SerializeField] GameObject otherPentagram1;
    [SerializeField] GameObject otherPentagram2;
    [SerializeField] string name;
   public void setShape()
    {
        recipe.currentRecipe = name;
        enabledPentagram.SetActive(true);
        otherPentagram1.SetActive(false);
        otherPentagram2.SetActive(false);

    }
}
