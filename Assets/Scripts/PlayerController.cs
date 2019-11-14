using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public Joystick joystick;

    public float movementSpeed;

    public GameObject firePoint;
    public GameObject bulletPrefab;
    public float bulletForce;

    [HideInInspector] public bool isWon;

    private void Start()
    {
        player = GetComponent<Rigidbody>();
        isWon = false;
    }

    private void Update()
    {
        if (!isWon)
        {
            //movement with velocity
            float horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
            float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

            player.velocity = new Vector3(horizontal, player.velocity.y, vertical);

            // control with joystick
            float horizontall = joystick.Horizontal * movementSpeed * Time.deltaTime;
            float verticall = joystick.Vertical * movementSpeed * Time.deltaTime;

            player.velocity = new Vector3(horizontall, player.velocity.y, verticall);
        } else
        {
            //do nothing
        }
        
    }
    
    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation) as GameObject;
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

        bulletRb.AddForce(transform.forward * bulletForce);

        Destroy(bullet, 2.0f);
    }
}
