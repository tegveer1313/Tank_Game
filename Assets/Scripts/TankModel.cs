using UnityEngine;

public class TankModel
{
    private TankController controller;

    public float movementSpeed;
    public float rotationSpeed;

    public TankType type;
    public Material color;


    public TankModel(float _Movement, float _Rotation, TankType tank, Material _color)
    {
        movementSpeed = _Movement;
        rotationSpeed = _Rotation;

        type = tank;
        color = _color;
    }

    public void SetTankController(TankController tankController)
    {
        controller = tankController;
    }
}