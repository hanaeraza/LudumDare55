using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnapOn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] bool isEmpty;
    [SerializeField] public GameObject currentObject;
    [SerializeField] GameObject newObject;
    void Start()
    {
        isEmpty = true;
        currentObject = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ingredient"))
        {
            Debug.Log("collision with ingredient detected");
            collision.GetComponent<Rigidbody2D>().MovePosition(transform.position);
            isEmpty = false;
            currentObject = collision.gameObject;
        }
        //if (isEmpty)
        //{
        //    collision.gameObject.transform.position=transform.position;
        //    currentObject=collision.gameObject;
        //}
        //else
        //{
        //    Destroy(currentObject);
        //    collision.gameObject.transform.position = transform.position;
        //    currentObject = collision.gameObject;
        //}
    }
}
