using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefab;
    public GameObject puntoDeDisparo;
    public string nombreAccion;
    public float cadenciaDisparo;


    void Update()
    {
        if (Input.GetButtonDown(nombreAccion))
        {
            InvokeRepeating("Disparar", 0f, cadenciaDisparo);
        }

        if (Input.GetButtonUp(nombreAccion))
        {
            CancelInvoke("Disparar");
        }

    }

    void Disparar() {
        Instantiate(prefab, puntoDeDisparo.transform.position, gameObject.transform.rotation);
    }

}
