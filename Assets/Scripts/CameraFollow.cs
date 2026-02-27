using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -80 && player.transform.position.x <= -80)
        {
            transform.position = new Vector3(-80, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 85 && player.transform.position.x >= 85)
        {
            transform.position = new Vector3(85, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
