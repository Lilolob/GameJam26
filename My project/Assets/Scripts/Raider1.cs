using UnityEngine;

public enum raiderState
{
    Idle,
    Walking,
    Attacking,
    Damaged,
    Dead
}

public class Raider1 : MonoBehaviour
{
    // Raider stats + states
    public raiderState currentState;

    public int health = 10;
    public int damage = 1;
    public int reloadTime = 1;
    public int reloadSpeed = 1;
    public int moveSpeed = 1;
    public int range = 1;


    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            currentState = raiderState.Dead;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = raiderState.Walking;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case raiderState.Idle:
                break;
            case raiderState.Walking:
                UpdateWalking();
                break;
            case raiderState.Attacking:
                break;
            case raiderState.Damaged:
                break;
            case raiderState.Dead:
                break;
        }
    }

    void UpdateWalking()
    {
        // Move raider at constant speed to the right
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    void UpdateDeath()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            currentState = raiderState.Attacking;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            currentState = raiderState.Walking;
        }
    }
}
