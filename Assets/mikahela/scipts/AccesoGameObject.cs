using UnityEngine;

public class AccesoGameObject : MonoBehaviour
{
    public GameObject pelota;

    void Start()
    {
        Debug.Log("Posición de la pelota: " + pelota.transform.position);
    }
}
