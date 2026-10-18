using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float velocidadX = 5f;
    public float velocidadY = 3f;
    public float velocidadZ = 4f;

    void Update()
    {
        transform.position = transform.position + new Vector3(velocidadX, velocidadY, velocidadZ) * Time.deltaTime;

        if (transform.position.x > 10 || transform.position.x < -10)
        {
            velocidadX = velocidadX * -1;
        }

        if (transform.position.y > 10 || transform.position.y < -10)
        {
            velocidadY = velocidadY * -1;
        }

        if (transform.position.z > 10 || transform.position.z < -10)
        {
            velocidadZ = velocidadZ * -1;
        }
    }
}
