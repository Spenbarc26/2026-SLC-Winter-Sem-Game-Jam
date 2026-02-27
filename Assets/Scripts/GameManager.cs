using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //makes singleton
    public int currentLevel {  get; private set; } //allows setting level

    public GameObject player;
    string sceneName;

    private void Awake()
    {
        //ensure only 1 instance of game manager
        if(instance == null)
        { 
            instance = this; 
            DontDestroyOnLoad(gameObject);
            ResetGame();
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void ResetGame()
    { 
        currentLevel = 0;
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
