using UnityEngine;

public class controller : MonoBehaviour
{
    public int speed = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        //  use wasd
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // Use physics engine to move
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed, ForceMode.VelocityChange);
        
    }
}
