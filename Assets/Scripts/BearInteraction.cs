using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearInteraction : MonoBehaviour
{
    public float interactionRange = 3f; // Rango de interacción
    public KeyCode interactionKey = KeyCode.E; // Tecla de interacción
    public Collider conditionalCollider; // Collider condicional

    private void Update()
    {
        // Verifica si el jugador está dentro del rango y presiona la tecla E
        if (Input.GetKeyDown(interactionKey) && IsPlayerInInteractionRange())
        {
            DestroyBear();
        }
    }

    private bool IsPlayerInInteractionRange()
    {
        // Obtén la posición del jugador y del oso de peluche
        Vector3 playerPosition = Camera.main.transform.position;
        Vector3 bearPosition = transform.position;

        // Calcula la distancia entre el jugador y el oso de peluche en el plano horizontal
        float distance = Vector2.Distance(new Vector2(playerPosition.x, playerPosition.z), new Vector2(bearPosition.x, bearPosition.z));

        // Devuelve true si el jugador está dentro del rango
        return distance <= interactionRange;
    }

    private void DestroyBear()
    {
        // Lógica para destruir el oso de peluche
        // Puedes cambiar esto según tus necesidades
        Destroy(gameObject);

        // Activar el collider condicional
        if (conditionalCollider != null)
        {
            conditionalCollider.enabled = true;
        }
    }
}
