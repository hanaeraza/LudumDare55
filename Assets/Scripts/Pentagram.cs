using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagram : MonoBehaviour
{
    [SerializeField] Collider2D collider;
    public int collisionCounter;
    // Start is called before the first frame update
    void Start()
    {
        collider = this.GetComponent<Collider2D>();
        collisionCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision detected!");
        collisionCounter++;
    }
    
}
