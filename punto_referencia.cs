using UnityEngine;

public class punto_referencia : MonoBehaviour
{
  public GameObject escudo_teletransportador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
          GameObject[] humanoides_1 = GameObject.FindGameObjectsWithTag("humanoide_tipo1");
          GameObject[] humanoides_2 = GameObject.FindGameObjectsWithTag("humanoide_tipo2");
      foreach (GameObject humanoide in humanoides_1)
      {
        humanoide.transform.position = escudo_teletransportador.transform.position;
      }
            foreach (GameObject humanoide in humanoides_2)
            {
                humanoide.transform.LookAt(transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
