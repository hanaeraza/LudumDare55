using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingGameManager : MonoBehaviour
{
    [SerializeField] GameObject line;
    [SerializeField] GameObject explosion;
    [SerializeField] Texture2D cursorBrush;
    [SerializeField] Texture2D normalCursor;
    [SerializeField] GameObject notified;

    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
        explosion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(Input.mousePosition, new Vector2((float)382.04, (float)502.99)) < 365 && Input.GetMouseButtonDown(0))
        {  
            Instantiate(line);
        } else
        {
            enabled = false;
            enabled = true;
        }
    }
    public void changeState()
    {
        enabled = !enabled;
        Debug.Log(enabled);
        if (enabled)
        {
            Cursor.SetCursor(cursorBrush, Vector2.zero, CursorMode.Auto);
            notified.SetActive(true);
        }
        else
        {
            Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.Auto);
            notified.SetActive(false);
        }
    }

    public void disablePaint()
    {
        enabled = false;
        Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.Auto);
        Debug.Log(enabled);
        notified.SetActive(false);
    }

}
