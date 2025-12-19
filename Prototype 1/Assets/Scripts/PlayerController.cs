using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Variables
    public float speed = 5.0f; // Speed variable for vehicle movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
