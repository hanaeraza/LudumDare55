using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using System.Linq;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
    [SerializeField] private GameObject finalScreen;
    [SerializeField] private TMP_Text endStats;
    [SerializeField] private TMP_Text finalStatsText;
    [SerializeField] private TotalStats finalStats;
    TypeWriterEffect typeWriterEffect;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Drawing", LoadSceneMode.Additive); 
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

        if (dayCounter.currentDay < 5)
        {
            StartCoroutine(waitForRequestFulfill());
        }
        else
        {
            String dailyStats = "Score\n" + "Total Customers: " + finalStats.totalCustomers + "\n" + "Total Fulfilled Orders: " + finalStats.totalSuccessOrders + "\n" + "Total Botched Orders: " + finalStats.totalBotchedOrders;
            finalScreen.SetActive(true);
            StartCoroutine(typeText(dailyStats, finalStatsText));
        }
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
            finalStats.totalCustomers++;

            if (currentRequest.correctlyFulfilled)
            {
                totalReqFulfilled++;
                finalStats.totalSuccessOrders++;
            }
            else
            {
                totalReqBotched++;
                finalStats.totalBotchedOrders++;
            }
            
            //Destroy(currentCustomer);
            currentRequest.fulfilled = false;
            currentRequest.correctlyFulfilled = false;
            currentRequest.accepted = false;
            yield return new WaitForSeconds(2); 

            yield return new WaitForSeconds(2);
        }

        String dailyStats = "Day: " + dayCounter.currentDay + "\n" + "Total Customers: " + totalCustomers + "\n" + "Total Fulfilled Orders: " + totalReqFulfilled + "\n" + "Total Botched Orders: " + totalReqBotched;
        dayCounter.currentDay++;
        endScreen.SetActive(true);
        StartCoroutine(typeText(dailyStats, endStats));
        

    }
    public object[,] getTodaysCustomers(int numOfCustomers, Request[] requestList){

        todaysCustomers = new object[numOfCustomers,2];

        for(int i = 0; i < numOfCustomers; i++)
        {
            todaysCustomers[i, 0] = requestList[UnityEngine.Random.Range(0, requestList.Length - 1)];
            todaysCustomers[i, 1] = allSprites.sprites[UnityEngine.Random.Range(0, allSprites.sprites.Length)];
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

}
