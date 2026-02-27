using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

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

