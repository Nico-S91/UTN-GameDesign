using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;
    public float cadenciaTiro;


    private void Awake()
    {
        InvokeRepeating("Disparar", 0f, cadenciaTiro);
    }

    void Disparar() {
        Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
    }

}
