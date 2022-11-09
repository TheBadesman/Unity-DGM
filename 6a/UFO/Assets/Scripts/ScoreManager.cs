using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //int and visual elements, both able to be modded
    public int score;
    public TextMeshProUGUI scoreText;

    // Increases and calls to update score
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
    // Decreases and calls to update score
    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    // Updates the score
    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }
}
