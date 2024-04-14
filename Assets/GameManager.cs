using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using System.Linq;
using UnityEngine.UI;
using TMPro;

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
    [SerializeField] private int totalReqBotched;
    [SerializeField] private float totalMoney;
    [SerializeField] private int totalCustomers;
    [SerializeField] private DayCounter dayCounter;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private TMP_Text endStats;
    TypeWriterEffect typeWriterEffect;
    // Start is called before the first frame update
    void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
        Debug.Log(dayCounter.currentDay == 1);
        switch (dayCounter.currentDay)
        {
            case 1: getTodaysCustomers(2, baseRequests.requests); Debug.Log("x"); 
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

        StartCoroutine(waitForRequestFulfill());

    }


    IEnumerator waitForRequestFulfill()
    {
        for (int i = 0; i < todaysCustomers.GetLength(0); i++)
        {
            currentRequest = (Request)todaysCustomers[i, 0];
            Requests.currentRequest = (Request)todaysCustomers[i, 0];
            GameObject currentCustomer = Instantiate(customerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            currentCustomer.GetComponent<RectTransform>().localScale = Vector3.one;
            currentCustomer.GetComponent<Text>().text = currentRequest.requestText;
            currentCustomer.GetComponent<SpriteRenderer>().sprite = (Sprite)todaysCustomers[i, 1];

            while (currentRequest.fulfilled == false)
            {
                yield return null;
            }

            totalCustomers++;

            if (currentRequest.correctlyFulfilled)
            {
                totalReqFulfilled++;
            }
            else
            {
                totalReqBotched++;
            }
            
            //Destroy(currentCustomer);
            currentRequest.fulfilled = false;
            currentRequest.correctlyFulfilled = false;

        }

        String dailyStats = "Summary" + "\n" + "Day " + dayCounter.currentDay + "\n" + "Total fulfilled orders: " + totalReqFulfilled + "\n" + "Total customers: " + totalCustomers + "\n" + "Total botched orders: " + totalReqBotched;
        dayCounter.currentDay++;
        endScreen.SetActive(true);
        StartCoroutine(typeText(dailyStats, endStats));
        

    }
    public object[,] getTodaysCustomers(int numOfCustomers, Request[] requestList){

        todaysCustomers = new object[numOfCustomers,2];

        for(int i = 0; i < numOfCustomers; i++)
        {
            todaysCustomers[i, 0] = requestList[UnityEngine.Random.Range(0, requestList.Length - 1)];
            todaysCustomers[i, 1] = allSprites.sprites[UnityEngine.Random.Range(0, allSprites.sprites.Length - 1)];
        }
        
        return todaysCustomers;
    }

    private IEnumerator typeText(string text, TMP_Text textLabel)
    {
        yield return typeWriterEffect.Run(text, textLabel);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator wait(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
