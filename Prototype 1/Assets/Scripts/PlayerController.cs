using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Variables
    private float vehicle_speed = 20.0f;
    private float turn_speed = 35.0f;

    private float input_horizontal;
    private float input_vertical;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Initialize inputs
        input_horizontal = Input.GetAxis("Horizontal");
        input_vertical = Input.GetAxis("Vertical");

        // Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * vehicle_speed * input_vertical);

        // Turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turn_speed * input_horizontal);
    }
}
