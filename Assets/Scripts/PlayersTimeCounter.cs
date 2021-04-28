using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayersTimeCounter : MonoBehaviour
{
    [SerializeField] private KeyCode restart;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private GameObject Timer;
    [SerializeField] private float timelapsed;
    [SerializeField] private string endSceneName;
    [SerializeField] private string otherMainMenu;
    private AudioSource audioSource;
    private Animator anim;
    private bool gameWon = false;
    private bool counterBegan = false;
    private bool musisStarted = false;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponentInChildren<Animator>();
        DontDestroyOnLoad(this.gameObject);
        Timer.SetActive(false);
        
    }

    void Update()
    {
        if (counterBegan)
        {
            timelapsed += Time.deltaTime;
            DisplayTime(timelapsed);

        }

        if(counterBegan && !musisStarted)
        {
            audioSource.Play();
            musisStarted = true;
        }

        if (gameWon && Input.GetKey(restart))
        {
            SceneManager.LoadScene("MainMenu");
            Destroy(this.gameObject);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer()
    {
        Timer.SetActive(true);
        counterBegan = true;
    }

    private void OnLevelWasLoaded(int level)
    {
        Debug.Log("testing");
        if(SceneManager.GetActiveScene().name == endSceneName)
        {
            counterBegan = false;
            AnimationPlay();
            audioSource.Stop();
            gameWon = true;
        }
        if(SceneManager.GetActiveScene().name == otherMainMenu)
        {
            Destroy(this.gameObject);
        }

    }
    void AnimationPlay()
    {
        anim.SetBool("EndLevel", true);
    }

}
