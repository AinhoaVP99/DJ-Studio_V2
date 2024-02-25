
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vidas : MonoBehaviour
{
    public static int score = 0;        // The player's score.
    Text text;                      // Reference to the Text component. "Text" red

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>(); // "Text" red
        // Reset the score.
        score = 0;
    }

    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score; // secound text red
    }

    static public void AddPoint()
    {  //Use script to add point
        score++;

    }
}