using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public TextMeshProUGUI timeText;

    void Update()
    {
        time();
        loose();
    }

    public void time()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            Time.timeScale = 1f;
        }
        else if (timeRemaining < 0)
        {
            timeRemaining = 0;
            Time.timeScale = 0f;
        }

        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        timeText.text = string.Format("Time Remaining {00}", seconds);
    }

    public void loose()
    {
        if (timeRemaining == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
    public void AddTime(float extraTime)
    {
        timeRemaining += extraTime;
    }
}
