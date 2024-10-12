using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput = 0;
    public float moveSpeed = 10f;
    public float xRange;
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
       
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * moveSpeed);
    }
}
