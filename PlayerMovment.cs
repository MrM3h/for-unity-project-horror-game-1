using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f; // Adjust this value to change the speed of movement 

    // Update is called once per frame
    void Update()
    {
        // Get the input from the arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement direction based on the input
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f);

        // Move the character
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    
}

