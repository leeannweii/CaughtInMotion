using UnityEngine;

public class DrawLineBetweenObjects : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    private LineRenderer lineRenderer;

    void Start()
    {
        // Get the Line Renderer component
        lineRenderer = GetComponent<LineRenderer>();

        // Set the positions of the Line Renderer
        lineRenderer.SetPosition(0, object1.transform.position);
        lineRenderer.SetPosition(1, object2.transform.position);
    }

    void Update()
    {
        // Update the positions of the Line Renderer
        lineRenderer.SetPosition(0, object1.transform.position);
        lineRenderer.SetPosition(1, object2.transform.position);
    }
}