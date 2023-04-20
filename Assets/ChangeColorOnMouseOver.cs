using UnityEngine;

public class ChangeColorOnMouseOver : MonoBehaviour
{
    public Material newMaterial;

    private Material oldMaterial;

    private void Start()
    {
        oldMaterial = GetComponent<Renderer>().material;
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = newMaterial;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = oldMaterial;
    }
}