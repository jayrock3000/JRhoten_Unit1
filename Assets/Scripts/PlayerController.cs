using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float 
        speed,      // Rate of forward/backward movement
        turnSpeed;

    private float
        horizontalInput,
        verticalInput;

    void Start()
    {
        // Initialize rate-of-change variables
        speed = 25.0f;
        turnSpeed = 75.0f;
    }

    void Update()
    {
        // Logs time, remove this?
        // Debug.Log(Time.deltaTime);

        // Get input from player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move vehicle based on player input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
