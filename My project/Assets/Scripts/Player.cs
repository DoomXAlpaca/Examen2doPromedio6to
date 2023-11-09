using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public float bulletSpeed = 10.0f;

    private Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent < Rigidbody >();
    }

    void Update()
    {
        moveSpeed = (moveSpeed + (0.1f*Time.deltaTime));

        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.O))
        {
            ShootBullet(bulletPrefab1, transform.forward, bulletSpeed);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            ShootBullet(bulletPrefab2, transform.forward, bulletSpeed * 2);
        }
    }

    void ShootBullet(GameObject bulletPrefab, Vector3 direction, float speed)
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        Vector3 bulletVelocity = transform.TransformDirection(direction.normalized * speed);

        bulletRigidbody.velocity = bulletVelocity;
    }
}