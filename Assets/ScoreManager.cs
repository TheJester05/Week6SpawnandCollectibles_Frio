using UnityEngine;
using TMPro;  // If you're using TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;  // Singleton instance to easily access this script
    public TextMeshProUGUI scoreText;     // Reference to the UI text element
    private int score = 0;                // Player's score

    private void Awake()
    {
        // Singleton pattern to ensure only one instance of ScoreManager exists
        if (instance == null)
        {
            instance = this;
        }
    }

    // Method to add points to the score
    public void AddScore(int amount)
    {
        score += amount;  // Increase score by the specified amount
        scoreText.text = score.ToString();  // Update the UI with the new score
    }

    // Method to reset the score (optional for when starting a new game)
    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();  // Reset the UI score display
    }
}
