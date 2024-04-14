using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class summoningOrder : MonoBehaviour
{
    [SerializeField] TMP_Text summoningOrderText;
    [SerializeField] GameObject orderDisplay;
    
    private void Start()
    {
        orderDisplay.SetActive(false);
    }
    
    void Update()
    {
        summoningOrderText.text = Requests.currentRequest.requestText;
        if (Requests.currentRequest.accepted)
        {
            orderDisplay.SetActive(true);
        } else
        {
            orderDisplay.SetActive(false);
        }
    }
}
