using UnityEngine;
using UnityEngine.UI;

public class OnMouseOverPanel : MonoBehaviour
{
    // The panel to show when the mouse hovers over the object
    public GameObject panel;

    void Start()
    {
        // Disable the panel by default
        panel.SetActive(false);
    }

    void OnMouseEnter()
    {
        // Show the panel when the mouse enters the object
        panel.SetActive(true);
    }

    void OnMouseExit()
    {
        // Hide the panel when the mouse exits the object
        panel.SetActive(false);
    }
}
