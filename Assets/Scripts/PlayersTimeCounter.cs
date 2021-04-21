using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayersTimeCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private GameObject Timer;
    [SerializeField] private float timelapsed;

    private bool counterBegan = false;


    void Start()
    {
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

}
