using UnityEngine;

public class AccesoGameObject : MonoBehaviour
{
    public GameObject pelota;
    void Start()
    {
        Debug.Log(pelota.transform.position);
    }

    void Update()
    {
        
    }
}
