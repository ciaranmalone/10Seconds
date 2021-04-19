using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timerController : MonoBehaviour
{

    private float timeRemaining = 10;
    private bool countDown = false;

    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private string nextScene;
    [SerializeField] private GameObject PlayerInstructions;
    [SerializeField] private bool LoadNextScene = false;
     
    private void Start()
    {
        PlayerInstructions.SetActive(true);
        StartCoroutine("StartTimer", 2);
    }
    void Update()
    {
        if (countDown) {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);

            }
            else
            {
                DisplayTime(0);
                countDown = false;
                TimeUp();
            }
        }
    }

    void TimeUp()
    {
        if (LoadNextScene)
        {
            SceneManager.LoadScene(nextScene);
        } else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;
        timeText.text = string.Format("{0:00}:{1:000}", seconds, milliSeconds);
    }

    private IEnumerator StartTimer(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        PlayerInstructions.SetActive(false);
        countDown = true;
    }
}
