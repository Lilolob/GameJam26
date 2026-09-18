using UnityEngine;
using UnityEngine.Playables;
using System.Collections;


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
    public int damage = 5;
    public int reloadTime = 1;
    public int reloadSpeed = 1;
    public int moveSpeed = 5;
    public int range = 1;
    public bool damaging;
    public bool isenemy;

    // Timer variables
    public float timeRemaining = 3; // seconds
    public bool timerIsRunning = false;



    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            currentState = soldierState.Dead;
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
                UpdateAttacking();
                break;
            case soldierState.Damaged:
                break;
            case soldierState.Dead:
                break;
        }
    }

    void UpdateWalking()
    {
        if (isenemy ==  true)
        {
            // Move soldier at constant speed to the right
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

    }

    IEnumerator UpdateAttacking()
    {
        yield return new WaitForSeconds(5);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Player")) 
        {
            currentState = soldierState.Attacking;
            Destroy(other);
        }  
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            currentState = soldierState.Walking;
        }
    }


}
