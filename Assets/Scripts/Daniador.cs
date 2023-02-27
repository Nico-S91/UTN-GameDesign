using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniador : MonoBehaviour
{
    public float danio;

    private void OnTriggerEnter(Collider other)
    {
        Vida vidaEntidad = other.gameObject.GetComponent<Vida>();
        vidaEntidad.cantidad -= danio;
        Destroy(gameObject);
    }
}
