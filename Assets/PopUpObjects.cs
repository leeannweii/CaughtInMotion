using UnityEngine;

public class PopUpObjects : MonoBehaviour
{
    public GameObject[] objectsToPopUp;
    public float scrollThreshold = 100f;
    private bool isScrolling = false;

    void Update()
    {
        float scrollDelta = Input.GetAxis("Mouse ScrollWheel");
        if (scrollDelta != 0f)
        {
            isScrolling = true;
        }
        if (isScrolling && scrollDelta == 0f)
        {
            if (Mathf.Abs(Input.GetAxis("Mouse Y")) > scrollThreshold)
            {
                foreach (GameObject obj in objectsToPopUp)
                {
                    obj.SetActive(true);
                }
            }
            isScrolling = false;
        }
    }
}
