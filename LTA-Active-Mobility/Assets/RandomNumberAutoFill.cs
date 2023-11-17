using UnityEngine;
using TMPro;

public class RandomTextAutoFill : MonoBehaviour
{
    public TMP_InputField inputField; // Reference to the TMP_InputField component in the Inspector.
    public string textPrefix = "player"; // Prefix to be added to the random number.

    private void Start()
    {
        // Generate a random number.
        int randomValue = Random.Range(1, 1000); // You can adjust the range as needed.

        // Combine the prefix and random number as text.
        string newText = textPrefix + randomValue.ToString();

        // Set the combined text in the input field.
        inputField.text = newText;
    }
}
