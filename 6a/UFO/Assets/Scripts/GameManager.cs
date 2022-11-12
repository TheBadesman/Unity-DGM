using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;
    //sets the time scale and tells the game that its not over
    private void Awake()
    {

        Time.timeScale = 1;
        isGameOver = false;    

    }
    // find the game over text
    void Start()
    {
        
        gameOverText = GameObject.Find("GameOverText");

    }
    //Checks to see if the game is over, and if it is it ends the game
    void Update()
    {
        
        if(isGameOver)
        {
            EndGame();
            GetComponent<AudioSource>().Pause();
        }
        else
        {
            gameOverText.gameObject.SetActive(false);
        }

    }
    //Stops time, and sets the game over text to active
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
