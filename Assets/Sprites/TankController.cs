using UnityEngine;

public class TankController
{
    private TankModel _model;
    private TankView _view;
    
    
    public TankController(TankModel tankModel, TankView tankView)
    {
        _model = tankModel;
        _view = tankView;

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    } 

}
