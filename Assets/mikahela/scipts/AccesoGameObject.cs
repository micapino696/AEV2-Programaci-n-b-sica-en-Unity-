using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesoGameObject : MonoBehaviour
{
    public GameObject pelota;

    void Start()
    {
        Debug.Log("Posición: " + pelota.transform.position);
    }
}