using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class acceptRequest : MonoBehaviour
{
    [SerializeField] TMP_Text upperText;
    [SerializeField] TMP_Text dialogText;
    [SerializeField] GameObject speechBubble;
   
    public void AcceptRequest()
    {
        //upperText.text = dialogText.text;
        Requests.currentRequest.accepted = true;
        speechBubble.SetActive(false);
    }

    [SerializeField] public Sprite regular;
    [SerializeField] public Sprite mouseOver;
    [SerializeField] public Sprite mouseClicked;
    public TextMeshPro buttonText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        AcceptRequest();
    }

    private void OnMouseEnter()
    {

    }

    private void OnMouseExit()
    {

    }

    private void OnMouseUpAsButton()
    {

    }
}