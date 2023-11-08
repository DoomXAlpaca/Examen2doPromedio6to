using UnityEngine;
using UnityEngine.SceneManagement; 

public class Enemy : MonoBehaviour
{
    public bool fire = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collided with Player");
            SceneManager.LoadScene("Perder");
        }
        else if (fire && other.CompareTag("ice"))
        {
            Destroy(gameObject); 
            Destroy(other.gameObject);
        }
        else if (!fire && other.CompareTag("fire"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}