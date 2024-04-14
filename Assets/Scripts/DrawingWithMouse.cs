using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingWithMouse : MonoBehaviour
{
   private LineRenderer lineRenderer;
   private Vector3 previousPosition;
    public float minDistance;
    //private MeshCollider meshCollider;
    EdgeCollider2D edgeCollider;
    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        edgeCollider = GetComponent<EdgeCollider2D>();
        lineRenderer.positionCount = 1;
        previousPosition = transform.position;
        //meshCollider = GetComponent<MeshCollider>();
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
        SetEdgeCollider(lineRenderer);
        if(Input.GetMouseButtonUp(0))
        {
            enabled = false;
            //Mesh mesh = new Mesh();
            //lineRenderer.BakeMesh(mesh, true);
            //meshCollider.sharedMesh = mesh;
            
        }

    }

    void SetEdgeCollider(LineRenderer lineRenderer)
    {
        List<Vector2> edges = new List<Vector2>();
        for(int point=0; point<lineRenderer.positionCount; point++)
        {
            Vector3 lineRendererPoint=lineRenderer.GetPosition(point);
            edges.Add(new Vector2(lineRendererPoint.x, lineRendererPoint.y));
        }
        edgeCollider.SetPoints(edges);
    }
}
