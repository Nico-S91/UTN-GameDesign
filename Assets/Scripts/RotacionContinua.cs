using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionContinua : MonoBehaviour
{
    public float rotacionX;
    public float rotacionY;
    public float rotacionZ;


    void Update()
    {
        transform.Rotate(rotacionX * Time.deltaTime, rotacionY * Time.deltaTime, rotacionZ * Time.deltaTime);
    }
}
