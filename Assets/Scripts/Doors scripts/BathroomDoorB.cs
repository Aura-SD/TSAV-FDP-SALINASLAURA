using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BathroomDoorB : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsMouseOverCollider())
        {
            SceneManager.LoadScene(1);
        }

    }

    bool IsMouseOverCollider()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        return Physics.Raycast(ray, out hit) && hit.collider != null && hit.collider.gameObject == gameObject;
    }

}
