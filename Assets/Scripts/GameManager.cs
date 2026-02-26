using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    string sceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerEggCollect>().eggs >= 3)
        {
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                SceneManager.LoadSceneAsync("Level Complete");
            }
            else if (SceneManager.GetActiveScene().name == "Level 2")
            {
                SceneManager.LoadSceneAsync("Game Complete");
            }
        }

        if (PlayerHealth.lives <= 0)
        {
            SceneManager.LoadScene("Death Scene");
        }
    }
}
