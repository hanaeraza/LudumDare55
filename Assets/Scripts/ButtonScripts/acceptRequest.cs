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
        Requests.currentRequest.accepted = true;
        if(speechBubble != null )
          speechBubble.SetActive(false);
    }

    [SerializeField] public Sprite regular;
    [SerializeField] public Sprite mouseOver;
    [SerializeField] public Sprite mouseClicked;
    public TextMeshPro buttonText;

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().sortingLayerName = "Dialog";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = mouseClicked;
        AcceptRequest();
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().sprite = mouseOver;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = regular;
    }

    private void OnMouseUpAsButton()
    {
        GetComponent<SpriteRenderer>().sprite = regular;
    }
}