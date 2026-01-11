using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject prefab_projectile;
    
    private float input_horizontal;
    private float speed = 17f;
    private float x_boundary = 16;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///
        // Movement Logic
        ///

        // Process horizontal input
        input_horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * input_horizontal * Time.deltaTime * speed);

        // Keep player in bounds
        if (transform.position.x < -1*x_boundary)
        {
            transform.position = new Vector3(-x_boundary, transform.position.y, transform.position.z);
        }

        if (transform.position.x > x_boundary)
        {
            transform.position = new Vector3(x_boundary, transform.position.y, transform.position.z);
        }

        ///
        // Projectile Logic
        ///

        // Launch a projectile on space press
        if (Input.GetKeyDown(KeyCode.Space)) { 
            Instantiate(prefab_projectile, transform.position, prefab_projectile.transform.rotation);
        }
    }
}
