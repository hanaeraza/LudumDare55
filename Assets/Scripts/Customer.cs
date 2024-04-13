using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] public GameObject customerSprite;
    [SerializeField] private Vector3 aPos;
    [SerializeField] private int atCounterPosition;
    private bool isAtCounter = false;
    [SerializeField] GameObject dialogBox;
    [SerializeField] private TMP_Text requestText;
    TypeWriterEffect typeWriterEffect;
    // Start is called before the first frame update
    void Start()
    {
        //request.requestText = "test";
        typeWriterEffect = GetComponent<TypeWriterEffect>();
        dialogBox.SetActive(false);
        //requestText.text = "test";
        customerSprite.GetComponent<RectTransform>().position = new Vector3(6, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (!isAtCounter && customerSprite.GetComponent<RectTransform>().position.x > atCounterPosition)
        {
           aPos = customerSprite.GetComponent<RectTransform>().position;
           aPos.x = aPos.y = aPos.z = 0;
           aPos.x = 5 * Time.deltaTime;
           customerSprite.GetComponent<RectTransform>().position -= aPos;

        } else if(!isAtCounter)
        {
            isAtCounter = true;
            dialogBox.SetActive(true);
            requestText.text = GetComponent<UnityEngine.UI.Text>().text;
            StartCoroutine(typeRequest(requestText.text));
        }

       
        
    }


    private IEnumerator typeRequest(string text)
    {
      yield return typeWriterEffect.Run(text, requestText);

    }
}
