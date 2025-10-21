using UnityEngine;

public class reaccion_player_humanoide2 : MonoBehaviour
{
    public colisiones colisionesScript;
    public GameObject escudo;
    public bool moverseHaciaEscudo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colisionesScript = GameObject.FindGameObjectWithTag("Player").GetComponent<colisiones>();
        colisionesScript.OnMiEvento2 += ReaccionarACollision;
    }

    private void ReaccionarACollision()
    {
        moverseHaciaEscudo = true;
        // moverse hacia el escudo

    }

    // Update is called once per frame
    void Update()
    {
        if (moverseHaciaEscudo && escudo != null)
        {
            Vector3 direction = escudo.transform.position - transform.position;
            direction.Normalize();
            transform.Translate(direction * Time.deltaTime * 5f, Space.World);
        }
        
    }
}
