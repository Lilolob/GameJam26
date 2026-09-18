using UnityEngine;

public class Raider1 : MonoBehaviour
{
    // Raider stats + states
    enum raiderState
    {
        Idle,
        Walking,
        Attacking,
        Damaged,
        Dead
    }
    public int health = 10;
    public int damage = 1;
    public int reloadTime = 1;
    public int reloadSpeed = 1;
    public int moveSpeed = 1;
    public int range = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
