using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeManager : MonoBehaviour
{
    //int and visual elements, both able to be modded
    public int lives;
    public TextMeshProUGUI livesText;

    // Increases and calls to update score
    public void IncreaseLives(int amount)
    {
        lives += amount;
        UpdateLivesText();
    }
    // Decreases and calls to update score
    public void DecreaseLives(int amount)
    {
        lives -= amount;
        UpdateLivesText();
    }

    // Updates the score
    public void UpdateLivesText()
    {
        livesText.text = "Lives: "+ lives;
        if(lives <= 0)
        {
            //if lives would drop below zero resets it to zero
            lives = 0;

        }
    }
}
