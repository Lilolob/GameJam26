using UnityEngine;
using System.Collections;

using static UnityEngine.Audio.ControlContext;


public class SkeletonSpawner : MonoBehaviour
{
    public Vector2 spawnPoint;

    public GameObject Skeleton1;
    public GameObject Skeleton2;
    public GameObject Skeleton3;
    private int x;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawns();
    }
    IEnumerator spawns()
    {
        yield return new WaitForSeconds(5);
        x = Random.Range(0, 9);
        if (x > 4)
        {
            Instantiate(Skeleton1, spawnPoint, transform.rotation);
        }
        if (x > 6)
        {
            Instantiate(Skeleton2, spawnPoint, transform.rotation);
        }
        else
        {
            Instantiate(Skeleton3, spawnPoint, transform.rotation);

        }

    }
}
