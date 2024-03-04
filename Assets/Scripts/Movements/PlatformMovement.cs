using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float maxRotationAngle = 30f; 

    private float currentVerticalRotation = 0f;
    private float currentHorizontalRotation = 0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        float newVerticalRotation = Mathf.Clamp(currentVerticalRotation + verticalInput, -maxRotationAngle, maxRotationAngle);
        float newHorizontalRotation = Mathf.Clamp(currentHorizontalRotation + horizontalInput, -maxRotationAngle, maxRotationAngle);

        transform.Rotate(newVerticalRotation - currentVerticalRotation, 0f, currentHorizontalRotation - newHorizontalRotation, Space.World);

        currentVerticalRotation = newVerticalRotation;
        currentHorizontalRotation = newHorizontalRotation;
    }
}
