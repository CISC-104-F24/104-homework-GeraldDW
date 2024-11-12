using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW3Trigger : MonoBehaviour

{
      public Vector3 jumpForce = new Vector3(0, 5, 0); // The force to apply for the jump
       public float teleportDistance = 5f; // Distance to move forward


       private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player enters the trigger
        {
            Debug.Log("Player entered the trigger!");
            // Add any other actions you want here (e.g., change color)
        }

   if (other.CompareTag("Player"))
        {
            // Calculate the new position
            Vector3 newPosition = transform.position + transform.forward * teleportDistance;
            transform.position = newPosition; // Teleport to the new position
            Debug.Log("Teleported to: " + newPosition);
        }

       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player stays in the trigger
        {
            Debug.Log("Player is inside the trigger!");
            // Actions while inside the trigger
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player exits the trigger
        {
            Debug.Log("Player exited the trigger!");
            // Add any actions you want here (e.g., reset color)
        }
    }
}
