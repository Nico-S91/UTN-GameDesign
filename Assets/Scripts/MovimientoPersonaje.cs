using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadRotacion;


    void Update()
    {
        if (Input.GetButton("Arriba"))
        {
            gameObject.transform.Translate(velocidadMovimiento * Time.deltaTime, 0, 0);
        }

        if (Input.GetButton("Abajo"))
        {
            gameObject.transform.Translate(-velocidadMovimiento * Time.deltaTime, 0, 0);
        }

        if (Input.GetButton("Derecha"))
        {
            gameObject.transform.Rotate(0, velocidadRotacion * Time.deltaTime, 0);
        }

        if (Input.GetButton("Izquierda"))
        {
            gameObject.transform.Rotate(0, -velocidadRotacion * Time.deltaTime, 0);
        }

    }
}
