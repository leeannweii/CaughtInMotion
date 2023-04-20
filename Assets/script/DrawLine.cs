using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineController))]
public class DrawLine : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    private LineController _lineController;

    private void Awake()
    {
        _lineController = GetComponent<LineController>();
    }

    void Start()
    {
        _lineController.SetUpLine(points);
    }

}
