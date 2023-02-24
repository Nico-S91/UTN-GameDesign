using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public float tiempoDetonacion;

    private bool explotar = false;

    private void Awake()
    {
        Invoke("Explotar", tiempoDetonacion);
    }

    void Update()
    {
        if (Input.GetButtonDown("Explotar"))
        {
            explotar = true;
        }
    }

    private void OnTriggerStay(Collider c)
    {
        if (explotar)
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
    }

    void Explotar() {
        explotar = true;
    }
}
