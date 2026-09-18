using UnityEngine;

public class Soldier1 : MonoBehaviour
{
    // Soldier stats + states
    enum soldierState
    {
        Idle,
        Walking,
        Attacking,
        Damaged,
        Dead
    }
    public int health = 10;
    public int cost = 1;
    public int damage = 1;
    public int reloadTime = 1;
    public int reloadSpeed = 1;
    public int moveSpeed = 1;
    public int range = 1;

    public void TakeDamage(int damage)      
    {
        health -= damage;
        if (health <= 0)
        {
            // death
        }
        else
        {
            // damaged (health already reduced)
        }
    }       

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
