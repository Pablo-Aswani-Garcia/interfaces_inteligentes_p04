using UnityEngine;

public class reaccion_cilindro_tipo_2 : MonoBehaviour
{
    private GameObject cilindro;
    public bool seguir_objeto = false;
    public GameObject objeto_que_seguir;
    public Vector3 distancia;
    private mensaje_en_colision mensajeEnColision;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cilindro = GameObject.FindGameObjectWithTag("cilindro");
        objeto_que_seguir = cilindro;
        mensajeEnColision = cilindro.GetComponent<mensaje_en_colision>();
        mensajeEnColision.OnMiEvento += ReaccionarACollision;
    }

    // Update is called once per frame
    void Update()
    {
        if (seguir_objeto && objeto_que_seguir != null)
        {
            Vector3 direction = objeto_que_seguir.transform.position - transform.position;
            direction.Normalize();
            distancia = objeto_que_seguir.transform.position - transform.position;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(direction);
        }
        
    }


    private void ReaccionarACollision()
    {
        seguir_objeto = true;
        Debug.Log("Reacción a la colisión detectada.");
    }
}
