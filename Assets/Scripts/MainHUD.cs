using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;


public class MainHUD : MonoBehaviour
{
    //set up a toggle value
    bool gamePaused = false;

    //for button sound
    [SerializeField] private AudioSource btnClickSound;
    [SerializeField] private AudioClip clickSound;

    [SerializeField] private TextMeshProUGUI livesTxt;
    [SerializeField] private TextMeshProUGUI titleTxt;
    [SerializeField] private TextMeshProUGUI eggsTxt;

    private int m_Lives;
    private int m_Points;
    private int m_Eggs;

    [SerializeField] private Button startBtn;
    [SerializeField] private Button pauseBtn;
    [SerializeField] private Button quitBtn;

    private void Awake()
    {
        startBtn = GetComponent<Button>();
        pauseBtn = GetComponent<Button>();
        quitBtn = GetComponent<Button>();

        
    }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLivesTxt()
    {
        livesTxt.text = $"Number Of Lives: {m_Lives}";

    }

    public void SetTitleTxt()
    {
        titleTxt.text = $"Points: {m_Points}";
    }

    public void SetEggsTxt()
    {
        eggsTxt.text = $"Number Of Eggs: {m_Eggs}";

    }


    public void PlayClick()
    {
        //play audio
        if (btnClickSound != null && clickSound != null)
        {
            btnClickSound.PlayOneShot(clickSound);
        }

    }
    public void StartGame()
    {
        GameManager.instance.ResetGame();
        

    }
    public void PauseGame()
    {

       
        // toggle pause
        gamePaused = !gamePaused;
        Time.timeScale = gamePaused ? 0.0f : 1.0f;

    }

    public void QuitGame()
    {
        Application.Quit();


    }

}

