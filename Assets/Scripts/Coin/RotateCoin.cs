using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
   
    private float rotationSpeed = 80f;
  
    void Update()
    {
        // rotate coins on x axis
        transform.Rotate(Time.deltaTime * rotationSpeed, 0f, 0f);

    }
}
