using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float maxRotationAngle = 30f; // Angle maximum de rotation en degrés

    private float currentVerticalRotation = 0f;
    private float currentHorizontalRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        // Calculer la nouvelle rotation tout en respectant les limites
        float newVerticalRotation = Mathf.Clamp(currentVerticalRotation + verticalInput, -maxRotationAngle, maxRotationAngle);
        float newHorizontalRotation = Mathf.Clamp(currentHorizontalRotation + horizontalInput, -maxRotationAngle, maxRotationAngle);

        // Appliquer la rotation
        transform.Rotate(newVerticalRotation - currentVerticalRotation, 0f, newHorizontalRotation - currentHorizontalRotation, Space.World);

        // Mettre à jour les valeurs actuelles de rotation
        currentVerticalRotation = newVerticalRotation;
        currentHorizontalRotation = newHorizontalRotation;
    }
}
