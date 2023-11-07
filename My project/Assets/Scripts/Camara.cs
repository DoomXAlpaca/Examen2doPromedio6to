using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target;            // El target que seguira al player
    public float smoothSpeed = 5.0f;    // El valor del del suavizado
    public Vector3 offset;              // Ajustar la posicion de la camara

    void LateUpdate()
    {
        if (target == null)
            return;

        // Calcular la posicion deseada de la camara
        Vector3 desiredPosition = target.position + offset;

        // Usar Lerp para cambiar entre la posicion actual de la camara y la posicion deseada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Usar esto para cambiar la posicion deseada de la camara
        transform.position = smoothedPosition;
    }
}