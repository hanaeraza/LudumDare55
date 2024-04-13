using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using System.Linq;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Requests baseRequests;
    [SerializeField] private Requests additonalRequests1;
    [SerializeField] private Requests additonalRequests2;
    [SerializeField] private Requests additonalRequests3;
    [SerializeField] private Requests additonalRequests4;
    [SerializeField] private SpritesList allSprites;
    [SerializeField] private GameObject customerPrefab;
    [SerializeField] private object[,] todaysCustomers;
    [SerializeField] private GameObject currentCustomer;
    [SerializeField] private Request currentRequest;
    [SerializeField] private int totalReqFulfilled;
    [SerializeField] private float totalMoney;
    [SerializeField] private int totalCustomers;
    [SerializeField] private int day = 1;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(day == 1);
        switch (day)
        {
            case 1: getTodaysCustomers(1, baseRequests.requests); Debug.Log("x"); 
                break;
            case 2: getTodaysCustomers(2, baseRequests.requests.Concat(additonalRequests1.requests).ToArray()); 
                break;
            case 3:
                getTodaysCustomers(3, baseRequests.requests
                    .Concat(additonalRequests1.requests)
                    .Concat(additonalRequests2.requests).ToArray()); 
                break;
            case 4: getTodaysCustomers(4, baseRequests.requests
                .Concat(additonalRequests1.requests)
                .Concat(additonalRequests2.requests)
                .Concat(additonalRequests3.requests).ToArray());
                break;
            case 5:
                getTodaysCustomers(4, baseRequests.requests
                .Concat(additonalRequests1.requests)
                .Concat(additonalRequests2.requests)
                .Concat(additonalRequests3.requests).
                Concat(additonalRequests4.requests)
                .ToArray());
                break;
        }

        currentRequest = (Request) todaysCustomers[0,0];
        GameObject currentCustomer = Instantiate(customerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        currentCustomer.GetComponent<Text>().text = currentRequest.requestText;
        currentCustomer.GetComponent<SpriteRenderer>().sprite = (Sprite) todaysCustomers[0, 1];
    }

    public object[,] getTodaysCustomers(int numOfCustomers, Request[] requestList){

        todaysCustomers = new object[numOfCustomers,2];

        for(int i = 0; i< numOfCustomers; i++)
        {
            todaysCustomers[i,0] = requestList[UnityEngine.Random.Range(0, requestList.Length -1)];
            todaysCustomers[i, 1] = allSprites.sprites[UnityEngine.Random.Range(0, allSprites.sprites.Length - 1)];
        }
        
        return todaysCustomers;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
