using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    // Start is called before the first frame update

    public Color enterColor = Color.red;    // Color when entering collision
    public Color stayColor = Color.yellow;   // Color when staying in collision
    public Color exitColor = Color.green;    // Color when exiting collision

    private Renderer objRenderer;             // Reference to the object's Renderer
    private int score = 0;                    // Player's score

    private void Start()
    {
        objRenderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Change color on collision enter
        objRenderer.material.color = enterColor;

        // Update score
        score++;
        Debug.Log("Score: " + score);

}
    private void OnCollisionStay(Collision collision)
    {
        // Only change to stayColor if it hasn't been set to enterColor
        if (objRenderer.material.color != enterColor)
        {
            objRenderer.material.color = stayColor;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Change color on collision exit
        objRenderer.material.color = exitColor;
    }
}