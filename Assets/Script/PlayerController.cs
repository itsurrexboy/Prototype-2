using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput = 0;
    public float moveSpeed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
       
       horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * moveSpeed);
    }
}
