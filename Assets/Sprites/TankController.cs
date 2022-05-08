using UnityEngine;

public class TankController
{
    private TankModel _model;
    private TankView _view;

    private Rigidbody rb;

    public TankController(TankModel tankModel, TankView tankView)
    {
        _model = tankModel;
        _view = GameObject.Instantiate<TankView>(tankView);

        rb = _view.GetRigidbody();

        _model.SetTankController(this);
        _view.SetTankController(this);
    }

    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = _view.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

}
