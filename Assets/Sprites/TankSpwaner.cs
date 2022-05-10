using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float RotationSpeed;

        public TankType type;
        public Material color;
    }

    public List<Tank> tankList;

    public TankView TankView;

    void Start()
    {
        /* Instantiating(Spawing) a "Tank" model in game.*/

        //Instantiate(TankView.gameObject, transform.position, Quaternion.identity);

        CreateTank();
    }


    private void CreateTank()
    {

        //Spawning Green tank { Enement number"0"} only.
        TankModel model = new TankModel(tankList[0].movementSpeed, tankList[0].RotationSpeed, tankList[0].type, tankList[0].color);

        TankController tankController = new TankController(model, TankView);
    }
}
