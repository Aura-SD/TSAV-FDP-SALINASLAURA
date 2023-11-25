using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private bool movimientoBloqueado = false;
    public float velocidadMovimiento = 5.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        DesbloquearMovimiento(); // Empieza desbloqueado
    }

    void Update()
    {
        if (!movimientoBloqueado)
        {
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");

            Transform camaraTransform = Camera.main.transform;

            Vector3 movimiento = (camaraTransform.right * movimientoHorizontal + camaraTransform.forward * movimientoVertical).normalized;

            movimiento = movimiento.normalized * velocidadMovimiento * Time.deltaTime;

            transform.Translate(movimiento, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (movimientoBloqueado)
            {
                DesbloquearMovimiento();
            }
            else
            {
                BloquearMovimiento();
            }
        }

        if (!movimientoBloqueado)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (movimientoBloqueado)
            {
                DesbloquearMovimiento();
            }
            else
            {
                BloquearMovimiento();
            }
        }
    }

    void BloquearMovimiento()
    {
        movimientoBloqueado = true;
    }

    void DesbloquearMovimiento()
    {
        movimientoBloqueado = false;
    }
}