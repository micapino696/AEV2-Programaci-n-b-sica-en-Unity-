using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public GameObject pelota;

    void Start()
    {
        pelota.GetComponent<Renderer>().material.color = Color.red;

        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        pelota.GetComponent<Renderer>().material.color = new Color(r, g, b);
    }

    void Update()
    {
        if (pelota.transform.position.x > 10 || pelota.transform.position.x < -10 ||
            pelota.transform.position.y > 10 || pelota.transform.position.y < -10 ||
            pelota.transform.position.z > 10 || pelota.transform.position.z < -10)
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            pelota.GetComponent<Renderer>().material.color = new Color(r, g, b);
        }
    }
}