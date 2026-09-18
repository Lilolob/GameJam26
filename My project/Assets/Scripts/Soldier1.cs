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
    int health = 10;
    int cost = 1;
    int damage = 1;
    int reloadTime = 1;
    int reloadSpeed = 1;
    int moveSpeed = 1;
    int range = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
