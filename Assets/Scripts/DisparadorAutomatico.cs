using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;


    private void Awake()
    {
        Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
