using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject deadMenu;
    static public int lives = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Bird"))
        {
            Debug.Log("PlayerDamaged");
            
            if (lives > 0)
            {
                lives--;
            }

            if (lives <= 0)
            {
                Time.timeScale = 0;
                transform.position = new Vector3(transform.position.x, -7, 0);
                deadMenu.SetActive(true);
            }
        }
    }
}
