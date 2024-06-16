using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component
    private int score = 0;

    void Start()
    {
        // Initialize the score text
        UpdateScoreText();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
