using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10.0f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        bulletRigidbody = GetComponent < Rigidbody >();
        transform.position += new Vector3(1f, 0, 0);
    }

    void Update()
    {
        Vector3 bulletVelocity = new Vector3(bulletSpeed, 0, 0);
        bulletRigidbody.velocity = bulletVelocity;

        Destroy(gameObject, 1.0f); 
    }
}