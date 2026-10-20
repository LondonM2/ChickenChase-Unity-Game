using TMPro;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    //Canvas Game Text
    public TMP_Text livesText;

    public GameObject gameOverText;
    public GameObject scoreText;
    private int lives = 3;
    
    //Updates 
    void Start()
    {
        UpdateLives();
        gameOverText.SetActive(false);
    }

    public void LoseLife()
    {
        lives--;
        UpdateLives();

        if (lives <= 0)
        {
            livesText.gameObject.SetActive(false);
            scoreText.SetActive(false);
            gameOverText.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    void UpdateLives()
    {
        livesText.text = "Lives: " + lives;
    }
}