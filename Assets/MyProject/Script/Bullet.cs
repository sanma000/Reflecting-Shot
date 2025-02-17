using UnityEngine;
using System.Collections.Generic;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int maxBounces = 3;
    public float range = 100f;
    public LayerMask reflayer;
    public LineRenderer lineRenderer;
    void Start()
    {
        List<Vector3> points = new List<Vector3>();
        Vector3 direction = transform.forward;
        Vector3 position = transform.position;

        points.Add(position);

        for (int i=0; i<maxBounces; i++)
        {
            RaycastHit hit;
            if (Physics.Raycast(position, direction, out hit, range, reflayer))
            {
                points.Add(hit.point);

                if (hit.collider.CompareTag("Environment"))
                {
                    Destroy(hit.collider.gameObject);
                    break;
                }

                direction = Vector3.Reflect(direction, hit.normal);
                position = hit.point;
            }
            else
            {
                points.Add(position + direction * range);
                break;
            }
        }

        DrawLaser(points);
        Destroy(gameObject, 0.1f);
    }

    // Update is called once per frame
    void DrawLaser(List<Vector3> points)
    {
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPositions(points.ToArray());
    }
}
