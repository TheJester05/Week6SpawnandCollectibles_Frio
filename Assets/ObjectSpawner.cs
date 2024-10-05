using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;  // Array to hold collectible and obstacle prefabs
    public float spawnInterval = 2f;     // Time between spawns
    public float spawnHeightMin = -3f;   // Minimum Y position for spawning
    public float spawnHeightMax = 3f;    // Maximum Y position for spawning
    public float spawnXMin = -10f;       // Minimum X position for spawning
    public float spawnXMax = -5f;        // Maximum X position for spawning
    public float spawnZPosition = 0f;     // Fixed Z position for spawning

    void Start()
    {
        // Start the spawn loop
        InvokeRepeating("SpawnObject", spawnInterval, spawnInterval);
    }

    void SpawnObject()
    {
        // Randomly pick collectible or obstacle
        GameObject objToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];
        
        // Random Y position for spawning
        float randomY = Random.Range(spawnHeightMin, spawnHeightMax);
        
        // Random X position for spawning
        float randomX = Random.Range(spawnXMin, spawnXMax);
        
        // Use fixed Z position
        float zPosition = spawnZPosition;
        
        Debug.Log($"Spawning {objToSpawn.name} at X: {randomX}, Y: {randomY}, Z: {zPosition}"); // Debug line
        
        // Spawn the object at the random position
        Vector3 spawnPosition = new Vector3(randomX, randomY, zPosition);
        Instantiate(objToSpawn, spawnPosition, Quaternion.identity);
    }
}








