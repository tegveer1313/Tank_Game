using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController controller;

    public float Movement;
    public float Rotation;

    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement(); 

        if(Movement != 0)
        {
            controller.Move(Movement, 30);
        }

        if (Rotation != 0)
        {
            controller.Rotate(Rotation, 20);
        }
    }

    private void movement()
    {
        Movement = Input.GetAxis("Horizontal");
        
        Rotation = Input.GetAxis("Vertical");
    }

    public void SetTankController(TankController tankController)
    {
        controller = tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rigidbody;
    }
}
