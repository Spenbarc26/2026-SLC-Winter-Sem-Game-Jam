using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdPatrol : MonoBehaviour
{
    private int patrolSpeed = 2;
    public Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            patrolSpeed = Random.Range(5, 15);
        }
        else if (SceneManager.GetActiveScene().name == "Level 2")
        {
            patrolSpeed = Random.Range(10, 20);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * patrolSpeed * Time.deltaTime;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
