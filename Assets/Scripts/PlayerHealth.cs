using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public AudioSource source;
    public AudioClip birdHit;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    static public int lives = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (lives == 3)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(true);
        }
        else if (lives == 2)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(false);
        }
        else if (lives == 1)
        {
            life1.SetActive(true);
            life2.SetActive(false);
            life3.SetActive(false);
        }
        else
        {
            life1.SetActive(false);
            life2.SetActive(false);
            life3.SetActive(false);
            SceneManager.LoadSceneAsync("Death Scene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 2)
        {
            life3.SetActive(false);
        }
        else if (lives == 1)
        {
            life2.SetActive(false);
        }
        else if (lives == 0)
        {
            life1.SetActive(false);
            Time.timeScale = 0;
            SceneManager.LoadSceneAsync("Death Scene");
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Bird"))
        {
            Debug.Log("PlayerDamaged");
            lives--;
            UIManager.instance.InstantiateHitUI();
            source.PlayOneShot(birdHit);
        }
    }
}
