using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public Transform sphereCenter; 
    public float rotationSpeed = 50f; 
    private bool isClockwise = true; 

    void Update()
    {
        
        float direction = isClockwise ? 1 : -1;

        
        transform.RotateAround(sphereCenter.position, Vector3.forward, direction * rotationSpeed * Time.deltaTime);

        
        if (Input.GetMouseButtonDown(0)) 
        {
            ToggleRotationDirection();
        }
    }

    
    void ToggleRotationDirection()
    {
        isClockwise = !isClockwise;
    }
}