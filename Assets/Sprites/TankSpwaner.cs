using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    public GameObject Tank;

    void Start()
    {
        /* Instantiating(Spawing) a "Tank" model in game.*/

        Instantiate(Tank, transform.position, Quaternion.identity);
    }
}
