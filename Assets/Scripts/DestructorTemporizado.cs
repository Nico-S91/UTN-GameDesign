using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorTemporizado : MonoBehaviour
{
    public float tiempoDestruccion;

    private void Awake()
    {
        Invoke("Autodestruirse", tiempoDestruccion);
    }

    void Autodestruirse() {
        Destroy(gameObject);
    }

}
