using UnityEngine;

public class BirdPatrol : MonoBehaviour
{
    private int patrolSpeed = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        patrolSpeed = Random.Range(5, 15);

        if (transform.position.x < 0)
        {
            transform.Rotate(0, 0, 0);
        }
        else if (transform.position.x > 0)
        {
            transform.Rotate(0, 180, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * patrolSpeed * Time.deltaTime;
    }
}
