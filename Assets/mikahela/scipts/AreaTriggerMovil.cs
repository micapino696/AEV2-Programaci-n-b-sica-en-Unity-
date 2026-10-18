
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaTriggerMovil : MonoBehaviour
{
    public float velocidad = 3f;

    private Vector3 direccion;

    void Start()
    {
        direccion = Random.onUnitSphere.normalized;

        velocidad = Random.Range(2f, 5f);
    }

    void Update()
    {
        transform.position += direccion * velocidad * Time.deltaTime;

        Vector3 posicion = transform.position;

        // Rebotar en los límites de X
        if (posicion.x >= 10 && direccion.x > 0 ||
            posicion.x <= -10 && direccion.x < 0)
        {
            direccion.x = -direccion.x;
        }

        // Rebotar en los límites de Y
        if (posicion.y >= 10 && direccion.y > 0 ||
            posicion.y <= -10 && direccion.y < 0)
        {
            direccion.y = -direccion.y;
        }

        // Rebotar en los límites de Z
        if (posicion.z >= 10 && direccion.z > 0 ||
            posicion.z <= -10 && direccion.z < 0)
        {
            direccion.z = -direccion.z;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "pelota001")
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }
    }
}
