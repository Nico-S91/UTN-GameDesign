using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniador : MonoBehaviour
{
    public float danio;

    private void OnCollisionEnter(Collision collision)
    {
        Vida vidaEntidad = collision.gameObject.GetComponent<Vida>();
        vidaEntidad.cantidad -= danio;
    }
}
