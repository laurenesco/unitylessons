using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float plane_speed = 1;
    private float rotationSpeed = 50;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * plane_speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(horizontalInput * rotationSpeed * Time.deltaTime * Vector3.up);
        transform.Rotate(((-1)*verticalInput) * rotationSpeed * Time.deltaTime * Vector3.right);
    }
}
