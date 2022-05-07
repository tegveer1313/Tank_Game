using UnityEngine;

public class TankModel
{
    private TankController controller;

    public TankModel()
    {

    }

    public void SetTankController(TankController tankController)
    {
        controller = tankController;
    }
}
