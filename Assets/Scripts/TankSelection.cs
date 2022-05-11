using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpwaner swpan;

    public void BlueTank()
    {
        swpan.CreateTank(TankType.BlueTank);
        this.gameObject.SetActive(false);
    }
    public void GreenTank()
    {
        swpan.CreateTank(TankType.GreenTank);
        this.gameObject.SetActive(false);
    }
    public void RedTank()
    {
        swpan.CreateTank(TankType.RedTank);
        this.gameObject.SetActive(false);
    }
}
