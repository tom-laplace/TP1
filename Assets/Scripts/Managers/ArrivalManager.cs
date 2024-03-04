using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrivalManager : MonoBehaviour
{
    private void onTriggerEnter(Collider other)
    {
        Debug.Log("ArrivalManager: OnTriggerEnter");
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("ArrivalManager: OnTriggerEnter: Ball");
            if (other.gameObject.TryGetComponent<BallManager>(out var ballManager))
                Debug.Log("ArrivalManager: OnTriggerEnter: Ball: BallManager");
                ballManager.Reset();
        }
    }

    private void onTriggerExit(Collider other)
    {
        Debug.Log("ArrivalManager: OnTriggerExit");
    }
}
