using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadPowerUp : MonoBehaviour
{
    public float bonus;

    private void OnTriggerEnter(Collider c)
    {
        MovimientoPersonaje movimientoPersonaje = c.gameObject.GetComponent<MovimientoPersonaje>();
        movimientoPersonaje.velocidadMovimiento += bonus;
        Destroy(gameObject);
    }

}
