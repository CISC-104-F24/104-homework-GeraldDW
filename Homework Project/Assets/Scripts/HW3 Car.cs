using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW3Jump : MonoBehaviour



  
  {
    public float moveSpeed = 5f; // Speed of movement
    private bool isMoving = false; // Flag to control movement

    private void Update()
    {
        // Move the object forward if isMoving is true
        if (isMoving)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is tagged as "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            isMoving = true; // Start moving
            Debug.Log("Object started moving forward");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Stop moving when the player exits the collision
        if (collision.gameObject.CompareTag("Player"))
        {
            isMoving = false; // Stop moving
            Debug.Log("Object stopped moving");
        }
    }
}
