using UnityEngine;

public class cambiar_color : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("humanoide_tipo2" ))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        } else if (collision.gameObject.CompareTag("humanoide_tipo1"))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
