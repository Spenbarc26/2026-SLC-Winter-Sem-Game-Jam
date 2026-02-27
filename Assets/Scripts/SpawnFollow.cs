using UnityEngine;

public class SpawnFollow : MonoBehaviour
{
    public Transform camera;
    private float offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(camera.transform.position.x - offset, transform.position.y, transform.position.z);
    }
}
