using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingGameManager : MonoBehaviour
{
    [SerializeField] GameObject line;
    [SerializeField] GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
        explosion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            explosion.SetActive(false);
            Instantiate(line);
        }
      
    }
    public void changeState()
    {
        enabled = !enabled;
        Debug.Log(enabled);
    }
}
