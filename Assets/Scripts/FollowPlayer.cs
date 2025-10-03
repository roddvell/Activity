using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform jugador; // Para saber a qui�n seguir
    public Vector3 offset;    // Para mantener una distancia y altura

    // LateUpdate se ejecuta despu�s de todos los c�lculos de Update.
    // Es el mejor lugar para el c�digo de la c�mara para evitar tirones.
    void LateUpdate()
    {
        // La posici�n de la c�mara ser� la posici�n del jugador m�s un desfase (offset)
        transform.position = jugador.position + offset;

        // Opcional pero recomendado: Haz que la c�mara siempre mire al jugador
        transform.LookAt(jugador);
    }
}