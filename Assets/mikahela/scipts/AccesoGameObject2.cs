
using UnityEngine;

public class AccesoGameObject2 : MonoBehaviour
{
    public GameObject pelota;
    public Vector3 velocidad = new Vector3(5, 3, 2);

    void Start()
    {
        Debug.Log(pelota.transform.position);
    }

    void Update()
    {
        pelota.transform.Translate(velocidad * Time.deltaTime);

        Vector3 posicion = pelota.transform.position;

        if (posicion.x > 10 || posicion.x < -10)
        {
            velocidad.x = -velocidad.x;
            CambiarColor();
        }

        if (posicion.y > 10 || posicion.y < -10)
        {
            velocidad.y = -velocidad.y;
            CambiarColor();
        }

        if (posicion.z > 10 || posicion.z < -10)
        {
            velocidad.z = -velocidad.z;
            CambiarColor();
        }
    }

    void CambiarColor()
    {
        pelota.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
