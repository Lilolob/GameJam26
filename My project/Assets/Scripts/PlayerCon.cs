using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCon : MonoBehaviour
{

    public GameObject raiders1;
    public GameObject raiders2;
    public GameObject raiders3;

    public int soulCostRaiders1;
    public int soulCostRaiders2;
    public int soulCostRaiders3;

    public int faction;
    public Vector2 spawnPoint;
    public int money;
    public int souls;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            souls++;
        }


        if (faction  == 1)
        {
            if (Keyboard.current.qKey.wasPressedThisFrame)
            {
                if (souls >= soulCostRaiders1)
                {
                    Instantiate(raiders1, spawnPoint, transform.rotation);
                    souls = souls - soulCostRaiders1;
                }
            }
            if (Keyboard.current.wKey.wasPressedThisFrame)
            {
                if (souls >= soulCostRaiders2)
                {
                    Instantiate(raiders2, spawnPoint, transform.rotation);
                    souls = souls - soulCostRaiders2;
                }
            }
            if (Keyboard.current.qKey.wasPressedThisFrame)
            {
                if (souls >= soulCostRaiders3)
                {
                    Instantiate(raiders1, spawnPoint, transform.rotation);
                    souls = souls - soulCostRaiders3;
                }
            }
        }

    }

    void SpawnRaider()
    {
        {

        }
    }
}
