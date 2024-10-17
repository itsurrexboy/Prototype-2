using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float outBound = 30f;
    public float lowBound = -9.5f;
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.z > outBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
