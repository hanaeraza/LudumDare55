using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapOn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] bool isEmpty;
    [SerializeField] GameObject currentObject;
    [SerializeField] GameObject newObject;
    void Start()
    {
        isEmpty = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEmpty)
        {
            collision.gameObject.transform.position=transform.position;
            currentObject=collision.gameObject;
        }
        else
        {
            currentObject = null;
            collision.gameObject.transform.position = transform.position;
            currentObject = collision.gameObject;
        }
    }
}
