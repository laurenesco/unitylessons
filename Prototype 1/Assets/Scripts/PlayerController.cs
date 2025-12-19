using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Variables
    public float vehicle_speed = 5.0f;
    public float turn_speed;

    public float input_horizontal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input_horizontal = Input.GetAxis("Horizontal");

        // Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * vehicle_speed);

        // Turn the vehicle
        transform.Translate(Vector3.right * Time.deltaTime * turn_speed * input_horizontal);
    }
}
