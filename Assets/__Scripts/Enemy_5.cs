using UnityEngine;

// Enemy that changes direction sporadically
public class Enemy_5 : Enemy
{
    [Header("Set in Inspector: Enemy_5")]
    public float changeDirectionTime = 2f; // How often enemy changes direction
    public float maxSpeed = 5f; // Enemy max speed

    private Vector3 direction; //  Enemy current movement direction
    private float timeSinceLastChange; // Timer for next direction change

    void Start()
    {
        ChangeDirection(); // Initialize random direction movement
    }

    void Update()
    {
        MoveSporadically(); // Moves enemy according to direction and speed
        // Check when to change direction
        if (Time.time - timeSinceLastChange > changeDirectionTime)
        {
            ChangeDirection(); // Change to new direction
        }
    }

    public override void Move()
    {
    }

    // Moves enemy in current direction at max speed
    void MoveSporadically()
    {
        transform.position += direction * maxSpeed * Time.deltaTime; // Update enemys position
    }

    // Changes enemys movement direction to a random vector
    void ChangeDirection()
    {
        // Create new direction vector with random X and Y, then normalize it
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0).normalized;
        // Reset direction change timer
        timeSinceLastChange = Time.time;
    }
}