using UnityEngine;
using UnityEngine.UI;

public class ObjectHoverButton : MonoBehaviour
{
    public GameObject buttonPrefab; // The button prefab to instantiate
    private GameObject buttonInstance; // The instance of the button prefab
    private bool isHovering; // Whether or not the mouse is hovering over the object

    void Update()
    {
        if (isHovering && buttonInstance == null)
        {
            // Instantiate the button prefab at the position of the object
            buttonInstance = Instantiate(buttonPrefab, transform.position, Quaternion.identity);
            buttonInstance.transform.SetParent(transform, false);
        }
        else if (!isHovering && buttonInstance != null)
        {
            // Destroy the button instance if the mouse is no longer hovering over the object
            Destroy(buttonInstance);
        }
    }

    void OnMouseEnter()
    {
        // Set the isHovering flag to true when the mouse enters the object's collider
        isHovering = true;
    }

    void OnMouseExit()
    {
        // Set the isHovering flag to false when the mouse exits the object's collider
        isHovering = false;
    }
}
