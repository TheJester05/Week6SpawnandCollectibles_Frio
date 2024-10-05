using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Trigger the game over logic
            GameManager.instance.GameOver();
            Destroy(gameObject); // Destroy the obstacle after hitting the player
        }
    }
}





