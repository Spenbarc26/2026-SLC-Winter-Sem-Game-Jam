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

    public void SetLevel(int L)
    {
        currentLevel = L;
    }

    
}
