using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] public GameObject customerSprite;
    [SerializeField] private Vector3 aPos;
    [SerializeField] private int atCounterPosition;
    [SerializeField] private int exitPosition;
    private bool isAtCounter = false;
    [SerializeField] GameObject dialogBox;
    [SerializeField] private TMP_Text requestText;
    TypeWriterEffect typeWriterEffect;
    private bool isWaiting = true;
    [SerializeField] float walkFreq;
    [SerializeField] float walkAmp;
    private bool goBack = false;
    // Start is called before the first frame update
    void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
        dialogBox.SetActive(false);
        customerSprite.GetComponent<RectTransform>().position = new Vector3((float)-13.9, 0, 0);
        StartCoroutine(wait(1));
    }

    // Update is called once per frame
    void Update()
    {
       
        if (!goBack && !isWaiting && !isAtCounter && customerSprite.GetComponent<RectTransform>().position.x < atCounterPosition)
        {
            
           aPos = customerSprite.GetComponent<RectTransform>().position;
           aPos.x = aPos.y = aPos.z = 0;
           aPos.x = 5 * Time.deltaTime;
           customerSprite.GetComponent<RectTransform>().position += aPos;
            customerSprite.GetComponent<RectTransform>().position = new Vector3(customerSprite.GetComponent<RectTransform>().position.x,
                 (float)(Mathf.Sin(Time.time * walkFreq) * walkAmp),
                customerSprite.GetComponent<RectTransform>().position.z);

        } else if(!goBack && !isWaiting && !isAtCounter)
        {
            isAtCounter = true;
            dialogBox.SetActive(true);
            requestText.text = GetComponent<UnityEngine.UI.Text>().text;
            StartCoroutine(typeRequest(requestText.text));
        } else if (customerSprite.GetComponent<RectTransform>().position.x < exitPosition)
        {
            Destroy(gameObject);

        } else if(goBack)
        {
            if (GetComponent<SpriteRenderer>().flipX != true)
                GetComponent<SpriteRenderer>().flipX = true;
            dialogBox.SetActive(false);
            aPos = customerSprite.GetComponent<RectTransform>().position;
            aPos.x = aPos.y = aPos.z = 0;
            aPos.x = 5 * Time.deltaTime;
            customerSprite.GetComponent<RectTransform>().position -= aPos;
            customerSprite.GetComponent<RectTransform>().position = new Vector3(customerSprite.GetComponent<RectTransform>().position.x,
                 (float)(Mathf.Sin(Time.time * walkFreq) * walkAmp),
                customerSprite.GetComponent<RectTransform>().position.z);
        }

        if(Requests.currentRequest?.fulfilled == true)
        {
            goBack = true;
        }
    }

    private IEnumerator typeRequest(string text)
    {
      yield return typeWriterEffect.Run(text, requestText);

    }

    private IEnumerator wait(int seconds)
    {
        isWaiting = true;
        yield return new WaitForSeconds(seconds);
        isWaiting = false;
    }

}
