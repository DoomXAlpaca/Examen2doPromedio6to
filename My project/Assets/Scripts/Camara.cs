using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target;            // El target a seguir
    public float smoothSpeed = 5.0f;    // El suavizado de la transicion
    public Vector3 offset;              // Posicion de la camara

    void LateUpdate()
    {
        if (target == null)
            return;
            
        // Calcular la posicion de la camara
        Vector3 desiredPosition = target.position + offset;

        // Usar Lerp para interpolar entre la posicion actual de la camara y la deseada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Determinar la posicion de la camara
        transform.position = smoothedPosition;
    }
}