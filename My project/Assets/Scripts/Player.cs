using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Esta es la velocidad de movimiento del jugador
    public GameObject bulletPrefab1; // Prefab de la primera bala
    public GameObject bulletPrefab2; // Prefab de la segunda bala
    public float bulletSpeed = 10f;

    private void Update()
    {
        // Esto hace que la bala se mueva a la derecha constantemente
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // Esto hace que el jugador pueda invocar distintas balas
        if (Input.GetKeyDown(KeyCode.O))
        {
            FireBullet1();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            FireBullet2();
        }
    }

    void FireBullet1()
    {
        // Instanciar y disparar la primera bala
        GameObject bullet = Instantiate(bulletPrefab1, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0);
    }

    void FireBullet2()
    {
        // Instanciar y disparar la segunda bala
        GameObject bullet = Instantiate(bulletPrefab2, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0);
    }
}