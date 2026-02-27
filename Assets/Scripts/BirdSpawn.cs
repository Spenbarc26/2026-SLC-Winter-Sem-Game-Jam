using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdSpawn : MonoBehaviour
{
    public float spawnDelay = 5;
    public GameObject bird;
    public float heightOffset = 9;

    private float timeSpawn = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            spawnDelay = 3f;
        }
        else if (SceneManager.GetActiveScene().name == "Level 2")
        {
            spawnDelay = 1.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSpawn += Time.deltaTime;

        if (timeSpawn >= spawnDelay)
        {
            SpawnBird();
        }
    }

    void SpawnBird()
    {
        float lowestPoint = transform.position.y;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(bird, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        timeSpawn = 0;
    }
}
