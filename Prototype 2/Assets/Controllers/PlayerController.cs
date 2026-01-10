using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal_input;
    private float speed = 17f;
    private float x_boundary = 16;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Process horizontal input
        horizontal_input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal_input * Time.deltaTime * speed);

        // Keep player in bounds
        if (transform.position.x < -1*x_boundary)
        {
            transform.position = new Vector3(-x_boundary, transform.position.y, transform.position.z);
        }

        if (transform.position.x > x_boundary)
        {
            transform.position = new Vector3(x_boundary, transform.position.y, transform.position.z);
        }
    }
}
