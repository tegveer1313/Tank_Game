using UnityEngine;

public class TankModel
{
    private TankController controller;

    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(float _Movement, float _Rotation)
    {
        movementSpeed = _Movement;
        rotationSpeed = _Rotation;
    }

    public void SetTankController(TankController tankController)
    {
        controller = tankController;
    }
}
