using UnityEngine;

public class AccesoGameObject : MonoBehaviour
{
    public GameObject pelota;
    public float velocidad = 5f;

  
    private Vector3 direccion = new Vector3(1f, 1f, 1f);

    void Start()
    {
       
        Debug.Log("Posición de la pelota: " + pelota.transform.position);
    }

    void Update()
    {
        
        pelota.transform.position += direccion * velocidad * Time.deltaTime;

 
        Vector3 pos = pelota.transform.position;

        
        if (pos.x > 10f || pos.x < -10f)
        {
            direccion.x = -direccion.x;
            pos.x = Mathf.Clamp(pos.x, -10f, 10f);
        }

      
        if (pos.y > 10f || pos.y < -10f)
        {
            direccion.y = -direccion.y;
            pos.y = Mathf.Clamp(pos.y, -10f, 10f);
        }

       
        if (pos.z > 10f || pos.z < -10f)
        {
            direccion.z = -direccion.z;
            pos.z = Mathf.Clamp(pos.z, -10f, 10f);
        }

       
        pelota.transform.position = pos;
    }
}