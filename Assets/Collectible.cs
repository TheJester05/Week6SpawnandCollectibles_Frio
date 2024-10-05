using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Increase the player's score
            ScoreManager.instance.AddScore(scoreValue);
            Destroy(gameObject); // Destroy the collectible after being collected
        }
    }
}




