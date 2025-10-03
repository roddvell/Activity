using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform jugador; // Para saber a quién seguir
    public Vector3 offset;    // Para mantener una distancia y altura

    // LateUpdate se ejecuta después de todos los cálculos de Update.
    // Es el mejor lugar para el código de la cámara para evitar tirones.
    void LateUpdate()
    {
        // La posición de la cámara será la posición del jugador más un desfase (offset)
        transform.position = jugador.position + offset;

        // Opcional pero recomendado: Haz que la cámara siempre mire al jugador
        transform.LookAt(jugador);
    }
}