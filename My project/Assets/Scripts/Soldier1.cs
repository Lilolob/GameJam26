using UnityEngine;
using UnityEngine.Playables;

public enum soldierState
{
    Idle,
    Walking,
    Attacking,
    Damaged,
    Dead
}

public class Soldier1 : MonoBehaviour
{
    // Soldier stats + states
    public soldierState currentState;

    public int health = 10;
    public int damage = 1;
    public int reloadTime = 1;
    public int reloadSpeed = 1;
    public int moveSpeed = 5;
    public int range = 1;

    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            // death
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = soldierState.Walking;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case soldierState.Idle:
                break;
            case soldierState.Walking:
                UpdateWalking();
                break;
            case soldierState.Attacking:
                break;
            case soldierState.Damaged:
                break;
            case soldierState.Dead:
                break;
        }
    }

    void UpdateWalking()
    {

        // Move player at cnstant speed to the right
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

    }
}
