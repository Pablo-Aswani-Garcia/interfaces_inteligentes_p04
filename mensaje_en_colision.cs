using UnityEngine;

public class mensaje_en_colision : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje OnMiEvento;
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisión con el jugador detectada.");
            OnMiEvento();
        }
        
    }
    // Update is called once per frame
    void Update()
    {

        
    }
}
