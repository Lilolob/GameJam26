using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCon : MonoBehaviour
{

    public GameObject Solider1;

    public GameObject SpawnPoint;
    private Vector2 SpawnPoints;
    public int money;
    public int souls;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            if(souls > 5)
                Instantiate(Solider1, SpawnPoints, transform.rotation);
        }
    }
}
