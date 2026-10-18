

using UnityEngine;

public class AccesoGameObject : MonoBehaviour
{
    public GameObject pelota;
    public float velocidad = 5f;

    private Vector3 direccion;
    private Renderer aspectoPelota;

    void Start()
    {
        aspectoPelota = pelota.GetComponent<Renderer>();

        Debug.Log("Posición inicial: " + pelota.transform.position);

        aspectoPelota.material.color = Color.red;

        // Dirección aleatoria en los tres ejes
        direccion = Random.onUnitSphere.normalized;
    }

    void Update()
    {
        pelota.transform.position +=
            direccion * velocidad * Time.deltaTime;

        Vector3 posicion = pelota.transform.position;

        // Rebote en X
        if (posicion.x >= 10 && direccion.x > 0)
        {
            direccion.x = -direccion.x;
            CambiarColor();
        }
        else if (posicion.x <= -10 && direccion.x < 0)
        {
            direccion.x = -direccion.x;
            CambiarColor();
        }

        // Rebote en Y
        if (posicion.y >= 10 && direccion.y > 0)
        {
            direccion.y = -direccion.y;
            CambiarColor();
        }
        else if (posicion.y <= -10 && direccion.y < 0)
        {
            direccion.y = -direccion.y;
            CambiarColor();
        }

        // Rebote en Z
        if (posicion.z >= 10 && direccion.z > 0)
        {
            direccion.z = -direccion.z;
            CambiarColor();
        }
        else if (posicion.z <= -10 && direccion.z < 0)
        {
            direccion.z = -direccion.z;
            CambiarColor();
        }
    }

    void CambiarColor()
    {
        aspectoPelota.material.color = Random.ColorHSV();
    }
}


