using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController controller;

    public float Movement;
    public float Rotation;

    public Rigidbody rigidbody;
    public MeshRenderer[] child;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.parent = transform;
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        movement(); 

        if(Movement != 0)
        {
            controller.Move(Movement, controller.GetTankModel().movementSpeed);
        }

        if (Rotation != 0)
        {
            controller.Rotate(Rotation, controller.GetTankModel().rotationSpeed);
        }
    }

    private void movement()
    {
        Movement = Input.GetAxis("Vertical");
        
        Rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController tankController)
    {
        controller = tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rigidbody;
    }

    public void CahngeColor(Material color)
    {
        for(int i=0; i<child.Length; i++)
        {
            child[i].material = color;
        }
    }
}
