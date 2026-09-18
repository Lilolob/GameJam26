using Unity.VisualScripting;
using UnityEngine;

public class Base : MonoBehaviour
{
    public int health = 100;
    public float time = 0;


    void Start()
    {
       
    }

    void Update()
    {
        time += Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!(time == Mathf.Floor(time)))
        {
            return;
        }
        if (other.CompareTag("Enemy"))
        {
            health = health - 5;
        }
    }
}
