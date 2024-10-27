using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW3Catch : MonoBehaviour
{
     private void OnCollisionEnter(Collision collision)
    {
   // Check if the object collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(!gameObject.activeSelf); // Toggles visibility
        }
}
}