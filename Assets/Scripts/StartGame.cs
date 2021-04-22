using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] PlayersTimeCounter playersTimeCounter;
    [SerializeField] private KeyCode start;
    [SerializeField] private KeyCode hardMode;
    [SerializeField] private string firstScene;
    [SerializeField] private string hardModeScene;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(start))
        {
            playersTimeCounter.StartTimer();
            SceneManager.LoadScene(firstScene);

        }

        if(Input.GetKeyDown(hardMode))
        {
            SceneManager.LoadScene(hardModeScene);
        }
    }
}
