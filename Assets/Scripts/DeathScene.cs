using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;


public class DeathScene : MonoBehaviour
{
    [SerializeField] private Button restartBtn;
    [SerializeField] private Button quitBtn;

    public void ResetLevel()
    {
        GameManager.instance.ResetGame();


    }
    public void QuitGame()
    {
        Application.Quit(); 


    }
}
