using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float rotateSpeed = 10f;

    void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
    }
}