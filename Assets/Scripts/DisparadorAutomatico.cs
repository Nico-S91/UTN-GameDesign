using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;
    public float cadenciaTiro;
    public GameObject origenDeDisparo;


    private void Awake()
    {
        InvokeRepeating("Disparar", 0f, cadenciaTiro);
    }

    void Disparar() {
        Instantiate(prefab, origenDeDisparo.transform.position, gameObject.transform.rotation);
    }

}
