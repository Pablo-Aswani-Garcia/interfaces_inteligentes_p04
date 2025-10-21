using Unity.VisualScripting;
using UnityEngine;

public class puntuaciones : MonoBehaviour
{
    public delegate void mensaje(int puntos);
    public static event mensaje OnMensaje;

    public int puntos = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("escudo_tipo_1"))
        {
            puntos += 10;
            Debug.Log("Puntos: " + puntos);
            OnMensaje(puntos);
        }
        if (collision.gameObject.CompareTag("escudo_tipo_2"))
        {
            puntos += 5;
            Debug.Log("Puntos: " + puntos);
            OnMensaje(puntos);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
