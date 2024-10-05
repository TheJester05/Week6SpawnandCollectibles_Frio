using UnityEngine;

public class MoveLeftToRight : MonoBehaviour
{
    public float speed = 5f; // Speed of movement

    void Update()
    {
        // Move the object from left to right
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}



