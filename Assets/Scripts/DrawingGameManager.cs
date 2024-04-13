using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingGameManager : MonoBehaviour
{
    [SerializeField] GameObject line;
    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(line);
        }
      
    }
    public void changeState()
    {
        enabled = !enabled;
        Debug.Log(enabled);
    }
}
