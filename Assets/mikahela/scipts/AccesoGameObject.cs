using UnityEngine;

public class AccesoGameObject : MonoBehaviour
{
    public GameObject pelota;
    public float velocidad = 5f;
    private Vector3 direccion = new Vector3(1, 1, 1);

    void Start()
    {
        Debug.Log(pelota.transform.position);
    }

    void Update()
    {
        pelota.transform.position += direccion * velocidad * Time.deltaTime;

        if (pelota.transform.position.x > 10 || pelota.transform.position.x < -10)
        {
            direccion.x = direccion.x * -1;
        }

        if (pelota.transform.position.y > 10 || pelota.transform.position.y < -10)
        {
            direccion.y = direccion.y * -1;
        }

        if (pelota.transform.position.z > 10 || pelota.transform.position.z < -10)
        {
            direccion.z = direccion.z * -1;
        }
    }
}