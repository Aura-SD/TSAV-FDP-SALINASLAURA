using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PositionManager : MonoBehaviour
{
    // Variable estática para almacenar la última posición del personaje
    public static Vector3 lastPlayerPosition;

    // Método para guardar la posición actual del jugador
    public static void SavePlayerPosition(Vector3 position)
    {
        lastPlayerPosition = position;
    }

    // Método para cargar la escena y devolver al jugador a su última posición
    public void ReturnToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Método para devolver al jugador a la última posición al iniciar la escena
    void Start()
    {
        // Verifica si existe una última posición guardada y mueve al jugador a esa posición
        if (lastPlayerPosition != Vector3.zero)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                player.transform.position = lastPlayerPosition;
            }
        }
    }
}
