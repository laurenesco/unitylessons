using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    private float boundary_top = 25f;
    private float boundary_bottom = -15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(
            $"LOCAL z = {transform.localPosition.z} | WORLD z = {transform.position.z}",
            this
        );
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy they object if it leave the camera view
        if (transform.position.z > boundary_top || transform.position.z < boundary_bottom)
        {
            Destroy(gameObject);
        }
    }
}
