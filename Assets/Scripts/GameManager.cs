using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<PlatformPrefab>();
        gameObject.AddComponent<BallPrefab>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
