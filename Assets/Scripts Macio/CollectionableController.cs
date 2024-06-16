using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionableController : MonoBehaviour
{
    public GameObject collectiblePrefab; // Prefab of the collectible object
    public GameObject player; // Reference to the player object
    public float spawnRadius = 1f; // Radius around the player within which to spawn collectibles
    public float spawnInterval = 2f; // Time interval between spawns

    void Start()
    {
        InvokeRepeating("SpawnCollectible", 1f, spawnInterval); // Start spawning collectibles
    }

    void SpawnCollectible()
    {
        // Generate a random position within the specified radius
        Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
        // Ensure the collectible spawns above 0 and below 2 units relative to the player's position
        float spawnY = Random.Range(0f, 1f);
        Vector3 spawnPosition = new Vector3(player.transform.position.x + randomPosition.x, player.transform.position.y + spawnY, player.transform.position.z + randomPosition.z);

        Instantiate(collectiblePrefab, spawnPosition, Quaternion.identity); // Instantiate the collectible
    }
}
