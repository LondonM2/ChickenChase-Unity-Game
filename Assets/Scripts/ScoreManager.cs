using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
    }
    public void AddChicken()
    {
        score++;
        UpdateScore();
    }
    // Update is called once per frame
    void UpdateScore()
    {
        scoreText.text = "Chickens: " + score;
    }
}
