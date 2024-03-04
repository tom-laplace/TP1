using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePrefab : MonoBehaviour
{
    public float rotationSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalRotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime; 
        float verticalRotation = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime; 

        transform.Rotate(verticalRotation, 0f, -horizontalRotation, Space.World);
    }
}
