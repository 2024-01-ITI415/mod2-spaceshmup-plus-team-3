using UnityEngine;

// Enemy that moves horizontally and spawns mini-enemies
public class Enemy_6 : Enemy
{
    [Header("Set in Inspector: Enemy_6")]
    public GameObject miniEnemyPrefab; // Mini-enemy prefab
    public float spawnDelay = 3f; // Delay between mini-enemy spawns
    public float horizontalSpeed = 5f; // Enemy horizontal movement speed
    public float movementRange = 5f; // Range enemy moves left and right
    public float verticalPosition = 4f; // Enemy vertical position from the top

    private float lastSpawnTime; // Time last mini-enemy was spawned
    private float originalX; // Enemy original X position
    private bool movingRight = true; // Is enemy currently moving right

    void Start()
    {
        lastSpawnTime = Time.time; // Record enemy start time
        originalX = transform.position.x; // Save original X position
        SetVerticalPosition(); // Set enemys vertical position
    }

    void Update()
    {
        MoveHorizontally(); // Handle horizontal movement
        // Check when to spawn new mini-enemy
        if (Time.time - lastSpawnTime > spawnDelay)
        {
            SpawnMiniEnemy(); // Spawn mini-enemy
            lastSpawnTime = Time.time; // Reset spawn timer
        }
    }

    // Set enemy vertical position
    void SetVerticalPosition()
    {
        Vector3 pos = transform.position; // Get current position
        pos.y = bndCheck.camHeight - verticalPosition; // Adjust vertical position
        transform.position = pos; // Apply new position
    }

    // Handles enemy horizontal movement
    void MoveHorizontally()
    {
        if (movingRight)
        {
            // Move right if within range
            if (transform.position.x < originalX + movementRange / 2)
            {
                transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;
            }
            else
            {
                movingRight = false; // Switch direction once range limit is reached
            }
        }
        else
        {
            // Move left if within range
            if (transform.position.x > originalX - movementRange / 2)
            {
                transform.position += Vector3.left * horizontalSpeed * Time.deltaTime;
            }
            else
            {
                movingRight = true; // Switch direction once range limit is reached
            }
        }
    }

    // Spawns mini-enemy at enemys current position
    void SpawnMiniEnemy()
    {
        Instantiate(miniEnemyPrefab, transform.position, Quaternion.identity); // Create new mini-enemy
    }
}
