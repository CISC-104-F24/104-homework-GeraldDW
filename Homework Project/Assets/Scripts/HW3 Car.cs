using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW3Jump : MonoBehaviour



  
  {
    public float moveDistance = 5f; // Distance to move on collision
    public float moveSpeed = 2f; // Speed of the movement
    private bool isMoving = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isMoving) // Ensure we don't trigger multiple movements
        {
            Vector3 collisionNormal = collision.contacts[0].normal;
            Vector3 movementDirection = DetermineMovementDirection(collisionNormal);
            StartCoroutine(MoveInDirection(movementDirection));
        }
    }

    private Vector3 DetermineMovementDirection(Vector3 normal)
    {
        // Move forward if hit from behind, left if hit from the right, and right if hit from the left
        if (Vector3.Dot(normal, transform.forward) > 0) // Collided from behind
        {
            return transform.forward;
        }
        else if (Vector3.Dot(normal, -transform.right) > 0) // Collided from the right
        {
            return -transform.right; // Move left
        }
        else if (Vector3.Dot(normal, transform.right) > 0) // Collided from the left
        {
            return transform.right; // Move right
        }
        
        return Vector3.zero; // No valid direction found
    }

    private IEnumerator MoveInDirection(Vector3 direction)
    {
        isMoving = true;
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = startPosition + direction.normalized * moveDistance;

        float journeyLength = Vector3.Distance(startPosition, targetPosition);
        float startTime = Time.time;

        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            float distCovered = (Time.time - startTime) * moveSpeed;
            float fractionOfJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startPosition, targetPosition, fractionOfJourney);
            yield return null; // Wait for the next frame
        }

        transform.position = targetPosition; // Ensure the final position is set
        isMoving = false; // Reset the flag
    }  
}
