using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    public TankView TankView;

    void Start()
    {
        /* Instantiating(Spawing) a "Tank" model in game.*/

        //Instantiate(TankView.gameObject, transform.position, Quaternion.identity);

        CreateTank();
    }


    private void CreateTank()
    {
        TankModel model = new TankModel(15, 45);

        TankController tankController = new TankController(model, TankView);
    }
}
