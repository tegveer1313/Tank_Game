using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    [System.Serializable] //---> Converting Data type to be used in unity editor.
    public class Tank
    {
        public float movementSpeed;
        public float RotationSpeed;

        public TankType type;
        public Material color;
    }

    public List<Tank> tankList;

    public TankView TankView;

    public void CreateTank(TankType _tankType)
    {
        if (_tankType == TankType.RedTank)
        {
            TankModel model = new TankModel(tankList[2].movementSpeed, tankList[2].RotationSpeed, tankList[2].type, tankList[2].color);
            TankController tankController = new TankController(model, TankView);
        }
        else if (_tankType == TankType.BlueTank)
        {
            TankModel model = new TankModel(tankList[0].movementSpeed, tankList[0].RotationSpeed, tankList[0].type, tankList[0].color);
            TankController tankController = new TankController(model, TankView);
        }
        else if (_tankType == TankType.GreenTank)
        {
            TankModel model = new TankModel(tankList[1].movementSpeed, tankList[1].RotationSpeed, tankList[1].type, tankList[1].color);
            TankController tankController = new TankController(model, TankView);
        }
    }
}