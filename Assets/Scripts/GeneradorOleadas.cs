using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOleadas : MonoBehaviour
{
    public GameObject prefab;
    public float cadenciaGeneracion;

    void Start()
    {
        InvokeRepeating("GenerarEntidad", 0f, cadenciaGeneracion);
    }

    void GenerarEntidad() {
        Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
