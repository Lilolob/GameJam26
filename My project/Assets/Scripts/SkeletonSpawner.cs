using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Audio.ControlContext;


public class SkeletonSpawner : MonoBehaviour
{
    public Vector2 spawnPoint;

    public GameObject Skeleton1;
    public GameObject Skeleton2;
    public GameObject Skeleton3;
    private int x;
    public int souls;
    public int soulcost;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            if (souls >= soulcost)
            {
                Instantiate(Skeleton3, spawnPoint, transform.rotation);
                souls = souls - soulcost;
            }
            
        }
    }

}
