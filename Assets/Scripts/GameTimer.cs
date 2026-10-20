using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject gameOverText;
    public GameObject scoreText;
    public GameObject livesText;

    public float timeRemaining = 60f;

    private bool timerRunning = true;

    void Update()
    {
        if (timerRunning)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                timerRunning = false;
                GameOver();
            }

            UpdateTimer();
        }
    }

    void UpdateTimer()
    {
        timerText.text = "Time: " + Mathf.CeilToInt(timeRemaining);
    }

    void GameOver()
    {
        timerText.gameObject.SetActive(false);
        scoreText.SetActive(false);
        livesText.SetActive(false);
    }
}
