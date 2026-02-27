using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public GameObject player;
    public GameObject jumpTut;
    public GameObject moveTut;

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

    void OnJump()
    {
        if (jumpTut.activeSelf == true)
        {
            jumpTut.SetActive(false);
        }
    }

    void OnMovement()
    {
        if (moveTut.activeSelf == true)
        {
            moveTut.SetActive(false);
        }
    }
}

