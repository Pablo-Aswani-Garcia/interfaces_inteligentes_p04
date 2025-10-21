using UnityEngine;

public class colisiones : MonoBehaviour
{
    public delegate void mensaje1();
    public mensaje1 OnMiEvento1;
    public delegate void mensaje2();
    public mensaje2 OnMiEvento2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("humanoide_tipo2"))
        {
            OnMiEvento1?.Invoke();
        }
        if (collision.gameObject.CompareTag("humanoide_tipo1"))
        {
            OnMiEvento2?.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
