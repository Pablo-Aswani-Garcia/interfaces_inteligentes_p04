using UnityEngine;
using UnityEngine.UI;

public class suscriptor : MonoBehaviour
{
    public puntuaciones puntuacionesScript;
    public event puntuaciones.mensaje OnMensajeHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntuaciones.OnMensaje += HandleOnMensaje;
    }

    private void HandleOnMensaje(int puntos)
    {
        this.GetComponent<Text>().text = "Puntos: " + puntos.ToString();
        if (puntos % 100 == 0)
        {
            this.GetComponent<Text>().color = Color.green;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
