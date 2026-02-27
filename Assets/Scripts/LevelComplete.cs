using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] private Button nextLevelBtn;
    [SerializeField] private Button quitBtn;

    public void NextLevel()
    {
        GameManager.instance.SetLevel(2);


    }
    public void QuitGame()
    {
        GameManager.instance.SetLevel(3);


    }

}
