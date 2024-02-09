using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; // Save start position for respawning
    }

    void Update()
    {
        if (transform.position.y < -5) // Check if the player has fallen
        {
            RespawnPlayer();
        }
    }

    public void RespawnPlayer()
    {
        transform.position = startPosition; // Move player back to start position
        // Reset velocity to prevent falling death loop
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
