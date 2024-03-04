using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrivalManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (other.gameObject.TryGetComponent<BallManager>(out var ballManager))
            ballManager.Reset();
        }
    }
}
