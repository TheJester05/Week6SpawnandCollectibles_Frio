using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;  // Singleton instance
    public GameObject gameOverPanel;     // Reference to the game over panel

    private void Awake()
    {
        // Ensure only one instance of the GameManager exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Destroy any duplicate instances
        }
    }

    public void GameOver()
    {
        // Show the game over panel
        gameOverPanel.SetActive(true);
        Time.timeScale = 0; // Stop the game
        Debug.Log("Game Over!");
    }
}

