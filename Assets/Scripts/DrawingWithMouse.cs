using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingWithMouse : MonoBehaviour
{
   private LineRenderer lineRenderer;
   private Vector3 previousPosition;
    public float minDistance;
    private MeshCollider meshCollider;
    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 1;
        previousPosition = transform.position;
        meshCollider = GetComponent<MeshCollider>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 currentPosition= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;

            if(Vector3.Distance(currentPosition, previousPosition)> minDistance)
            {

                if(previousPosition == transform.position)
                {
                    lineRenderer.SetPosition(0, currentPosition);
                }
                else
                {
                    lineRenderer.positionCount++;
                    lineRenderer.SetPosition(lineRenderer.positionCount - 1, currentPosition);

                }
                
                previousPosition = currentPosition;
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            enabled = false;
            Mesh mesh = new Mesh();
            lineRenderer.BakeMesh(mesh, true);
            meshCollider.sharedMesh = mesh;
        }

    }
}
