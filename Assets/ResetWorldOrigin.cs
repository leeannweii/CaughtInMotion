using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetWorldOrigin : MonoBehaviour
{
    Vector3 originalPos;

    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        //alternatively, just: originalPos = gameObject.transform.position;

    }
    public void ResetPosition()
    {

        {
            gameObject.transform.position = originalPos;
        }

    }   
}
