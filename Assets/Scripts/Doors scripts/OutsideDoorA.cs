using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutsideDoorA : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsMouseOverCollider())
        {
            SceneManager.LoadScene(2);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PerformRaycast();
        }
    }

    bool IsMouseOverCollider()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        return Physics.Raycast(ray, out hit) && hit.collider != null && hit.collider.gameObject == gameObject;
    }

    void PerformRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Outside doorcita :)");
        }
    }
}
