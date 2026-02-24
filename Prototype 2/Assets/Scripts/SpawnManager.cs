using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float animalRate = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Spawn animals
        InvokeRepeating("SpawnRandomAnimal", 2, animalRate);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int index = Random.Range(0, animalPrefabs.Length);
        int spawn_location = Random.Range(-18, 20);
        Instantiate(animalPrefabs[index], new Vector3(spawn_location, 0, 20), animalPrefabs[index].transform.rotation);
    }
}
