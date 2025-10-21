using UnityEngine;

public class follow : MonoBehaviour
{
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            offset = transform.position - player.transform.position;
        }
    }



    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Vector3 targetPosition = player.transform.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5);
        }   
    }
}
