using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    public int health;
    public int spawn_rate;
    public Skeleton1 Skeleton_1;
    public Rigidbody2D RigBod;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("Space"))
        {
            Skeleton1 Skeleton_1 = Skeleton1.Instantiate(this.Skeleton_1);
        }
    }
}
