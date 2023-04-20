using UnityEngine;
using UnityEngine.UI;

public class ObjectHover : MonoBehaviour
{
    public string hoverText;
    public GameObject textBoxPrefab;

    private GameObject textBoxInstance;

    void Start()
    {
        // Create an instance of the text box prefab
        textBoxInstance = Instantiate(textBoxPrefab, transform.position, Quaternion.identity);
        textBoxInstance.SetActive(false);
    }

    void OnMouseEnter()
    {
        // Show the text box and set its text
        textBoxInstance.SetActive(true);
        Text textBoxText = textBoxInstance.GetComponentInChildren<Text>();
        textBoxText.text = hoverText;
    }

    void OnMouseExit()
    {
        // Hide the text box
        textBoxInstance.SetActive(false);
    }
}