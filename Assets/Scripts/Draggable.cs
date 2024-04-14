using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        //Debug.Log("Mouse down on object");
        mousePositionOffset=gameObject.transform.position - GetMouseWorldPosition();

    }
    private void OnMouseDrag()
    {
        //Debug.Log("Mouse drag on object");
        transform.position = GetMouseWorldPosition()+mousePositionOffset;
    }
}
