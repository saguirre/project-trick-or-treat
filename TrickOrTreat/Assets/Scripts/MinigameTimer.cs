using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MinigameTimer : MonoBehaviour
{
    public float timeRemaining = 15;
    public bool timerIsRunning = false;
    public Text timeText;
    public float minigameNumber;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                if(minigameNumber == 1){
                    Singleton.Instance.inv.Add(Key.KeyType.Yellow);
                }else{
                    Singleton.Instance.inv.Add(Key.KeyType.Red);
                }
                SceneManager.LoadScene("NiceJob");
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}