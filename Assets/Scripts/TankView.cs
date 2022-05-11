using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController controller;

    public float Movement;
    public float Rotation;
    public float BulletSpeed;

    public Rigidbody rigidbody;
    public GameObject Bullet;
    public Transform Bullet_Spawner;
    public MeshRenderer[] TankSubObjects;


    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.parent = transform;
        cam.transform.position = new Vector3(0f, 3f, -4f);
        cam.transform.rotation = Quaternion.Euler(13.35f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        movement(); 
        Fire(BulletSpeed);

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
        for(int i=0; i<TankSubObjects.Length; i++)
        {
            TankSubObjects[i].material = color;
        }
    }

    public void Fire(float bulletSpeed)
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject tempBullet = Instantiate(Bullet, Bullet_Spawner.position, transform.rotation);
            Rigidbody tempBulletRigi = tempBullet.GetComponent<Rigidbody>();
            tempBulletRigi.AddForce(tempBulletRigi.transform.forward * bulletSpeed);
            Destroy(tempBullet, 5f);
        }
    }
}