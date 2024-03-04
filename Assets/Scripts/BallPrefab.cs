using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallPrefab : MonoBehaviour
{
    public Vector3 ballPosition = new(0, 0, 0);
    public float speed = 5f;
    public bool isDestroyed = false;
    public Collider collision;

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveBall()
    {
        transform.position = new Vector3(ballPosition.x, ballPosition.y, ballPosition.z);
    }

    public void DestroyBall()
    {
        isDestroyed = true;
        Destroy(gameObject);
    }

    public void RespawnBall()
    {
        isDestroyed = false;
        transform.position = new Vector3(0, 0, 0);
    }
}
