using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HW4 : MonoBehaviour
{

     // Define public variables for color change
    public Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow };  // Predefined colors: Red, Blue, Green, Yellow
    public Color currentColor;

    // Define the state for color change
    public bool colorChanged = false;

    // Text and UI elements to update
    public string currentText;  // For number on the card
    public TextMeshProUGUI demoTitle;  // Example text for title
    public TextMeshProUGUI bottomCenterText;  // Example text for number
    public Image background;  // Image component to change the background color
    public Button colorButton;  // Button to change color
    public Button numberButton;  // Button to change number
    public Button shuffleButton;  // Button to shuffle both color and number
    public TextMeshProUGUI thirdTextBox;

  

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the starting color (using Image component)
        currentColor = colors[0];  // Set to Red as the default color
        background.color = currentColor;

       
        currentText = bottomCenterText.text;

    
        if (colorButton != null)
        {
            colorButton.onClick.AddListener(ChangeColor); // Button to change color
        }

        if (numberButton != null)
        {
            numberButton.onClick.AddListener(ChangeNumber); // Button to change number
        }

        if (shuffleButton != null)
        {
            shuffleButton.onClick.AddListener(ShuffleCard); // Button to shuffle color and number
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Method to change color between startingColor and nextColor
    public void ChangeColor()
    {
        Debug.Log("Changing Color");

    // Get the index of the current color
    int currentColorIndex = System.Array.IndexOf(colors, currentColor);

    // Increment the index and make sure it stays within the bounds of the colors array (4 colors)
    int nextColorIndex = (currentColorIndex + 1) % colors.Length;

    // Set the new color based on the updated index
    currentColor = colors[nextColorIndex];

    // Apply the new color to the background (Image component)
    background.color = currentColor;

    // Log the change for debugging purposes
    Debug.Log("New color: " + currentColor);
    }

    // Method to change the number on the card between 1 and 9
    public void ChangeNumber()
    {
       // Generate a random number between 1 and 9
    int randomNumber = Random.Range(1, 10);  // Random.Range is inclusive of the first number and exclusive of the second, so 1-9 works.

    // Update the text to show the new number
    string newNumberText = randomNumber.ToString();  // Store the random number as text

    // Update all the text boxes
    bottomCenterText.text = newNumberText;  // Update the number in bottomCenterText
    demoTitle.text = newNumberText;  // Update the number in demoTitle
    if (thirdTextBox != null)
    {
        thirdTextBox.text = newNumberText;  // Update the number in the third text box
    }
    }

    // Method to shuffle both color and number
    public void ShuffleCard()
    {
        // Call both methods to change color and number
        ChangeColor(); // Change color
        ChangeNumber(); // Change number
    }


   
    



    
     
}
