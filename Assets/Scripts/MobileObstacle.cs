using UnityEngine;

public class MobileObstacle : MonoBehaviour
{
    // Esta función se llama automáticamente cuando otro objeto choca con este.
    private void OnCollisionEnter(Collision collision)
    {
        // Primero, comprobamos si el objeto que nos ha chocado tiene la etiqueta "Player".
        if (collision.gameObject.CompareTag("Player"))
        {
            // Si es el jugador, obtenemos nuestro propio componente Rigidbody.
            Rigidbody rb = GetComponent<Rigidbody>();

            // Si encontramos el Rigidbody (que debería estar ahí)...
            if (rb != null)
            {
                // ...desactivamos la propiedad "Is Kinematic".
                rb.isKinematic = false;
            }
        }
    }
}