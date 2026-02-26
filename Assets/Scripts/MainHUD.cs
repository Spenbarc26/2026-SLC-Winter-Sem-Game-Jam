using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainHUD : MonoBehaviour
{
    //set up a toggle value
    bool gamePaused = false;

    //for button sound
    [SerializeField] private AudioSource btnClickSound;
    [SerializeField] private AudioClip clickSound;
    
    [SerializeField] private Button startBtn;
    [SerializeField] private Button pauseBtn;
    [SerializeField] private Button quitBtn;

    private void Awake()
    {
        startBtn = GetComponent<Button>();
        pauseBtn = GetComponent<Button>();
        quitBtn = GetComponent<Button>();

        //add audio
        startBtn.onClick.AddListener(PlayClick);
        pauseBtn.onClick.AddListener(PlayClick);
        quitBtn.onClick.AddListener(PlayClick);
    }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClick()
    {
        //play audio
        if (btnClickSound != null && clickSound != null)
        {
            btnClickSound.PlayOneShot(clickSound);
        }

    }

    public void PauseGame()
    {

        Debug.Log("Pause Game called");
        // toggle pause
        gamePaused = !gamePaused;
        Time.timeScale = gamePaused ? 0.0f : 1.0f;

    }

}

/*
 * using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    //set up a toggle value
    bool gamePaused = false;
    public Slider expSlider;
    [SerializeField]
    private GameObject statsScreen;
    [SerializeField]
    private GameObject inventScreen;
    


    //for button sound
    [SerializeField] private AudioSource returnBtnClickSound;
    [SerializeField] private AudioClip clickSound;
    [SerializeField] private Button mainBtn;
    [SerializeField] private Button levelPopBtn;
    [SerializeField] private Button statsPopBtn;
    [SerializeField] private Button invPopBtn;
    [SerializeField] private Button statsPageBtn;
    [SerializeField] private Button invPageBtn;
    [SerializeField] private Button credPageBtn;
    [SerializeField] private Button pauseBtn;

    //audio for player inventory screen
    [SerializeField] private AudioSource playerInventAudio;
    [SerializeField] private AudioClip inventSound;

    private void Awake()
    {
        //ref this btn
        mainBtn = GetComponent<Button>();
        levelPopBtn = GetComponent<Button>();
        statsPopBtn = GetComponent<Button>();
        invPopBtn = GetComponent<Button>();
        statsPageBtn = GetComponent<Button>();
        invPageBtn = GetComponent<Button>();
        credPageBtn = GetComponent<Button>();
        pauseBtn = GetComponent<Button>();

        mainBtn.onClick.AddListener(PlayClick);
        levelPopBtn.onClick.AddListener(PlayClick);
        statsPopBtn.onClick.AddListener(PlayClick);
        
        statsPageBtn.onClick.AddListener(PlayClick);
        invPageBtn.onClick.AddListener(PlayClick);
        credPageBtn.onClick.AddListener(PlayClick);
        pauseBtn.onClick.AddListener(PlayClick);
        

    }
    private void Start()
    {
        invPopBtn.onClick.AddListener(PlayInventory);
        
    }

    

    public void MainMenuBtn()
    {
        Debug.Log("Get MainMenu Scene");
        //loads the game scene which is index 1
        SceneManager.LoadScene("MainMenuScenes");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

   


    public void PlayClick()
    {
        //play audio
        if (returnBtnClickSound != null && clickSound != null)
        {
            returnBtnClickSound.PlayOneShot(clickSound);
        }
        
    }


    //page
    public void StatsBtn()
    {
        Debug.Log("Get Stats Scene");
        //loads the game scene which is index 1
        SceneManager.LoadScene("Stats");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    
    public void InventBtn()
    {
        Debug.Log("Get Inventory Scene");
        //loads the game scene which is index 1
        SceneManager.LoadScene("Inventory");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
       
    }

    public void CreditsBtn()
    {
        Debug.Log("Get Credit Scene");
        //loads the game scene which is index 1
        SceneManager.LoadScene("Credits");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
       // SceneManager.LoadScene("Inventory");
    }

    public void PauseGame()
    {
        
        Debug.Log("Pause Game called");
        // toggle pause
        gamePaused = !gamePaused;
        Time.timeScale = gamePaused ? 0.0f : 1.0f;

    }

    
    public void UpdateExperiance(float v)
    {
        expSlider.value = v;
    }
}
 * 
 * 
 */