using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    // Este método se llama cuando otro Collider entra en este Collider
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el Collider que entró es el del personaje
        if (other.CompareTag("Player"))
        {
            // Carga la escena número 4
            SceneManager.LoadScene(4);
        }
    }

}
