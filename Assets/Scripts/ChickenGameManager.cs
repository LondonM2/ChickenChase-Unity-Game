
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ChickenGameManager : MonoBehaviour
{
    public Text scoreText;
    public Text messageText;
    public int eggsToWin = 3;

    private int score = 0;

    void Start()
    {
        UpdateScore();
        if (messageText != null)
            messageText.text = "Collect 3 eggs!";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Egg"))
        {
            score++;
            UpdateScore();
            Destroy(other.gameObject);

            if (score >= eggsToWin &&
                messageText != null)
            {
                messageText.text = "YOU WIN!";
            }
        }
    }

    void UpdateScore()
    {
        if (scoreText != null)
            scoreText.text = "Eggs: " + score;
    }
}
