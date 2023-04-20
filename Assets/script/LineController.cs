using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineController : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private Transform[] points;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();

    }

    public void SetUpLine(Transform[] points)
    {
        _lineRenderer.positionCount = points.Length;
        this.points = points;
    }

    private void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            _lineRenderer.SetPosition(i, points[i].position);
        }
    }
}
