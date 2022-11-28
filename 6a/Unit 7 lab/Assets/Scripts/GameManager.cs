using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    private bool gamePaused = false;

    public UnityEvent pauseScreenEvent, unpauseEvent;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if(gamePaused != true)
            {

                gamePaused = true;
                PauseGame();
                pauseScreenEvent.Invoke();

            }
            else
            {
                
                gamePaused = false;
                UnpauseGame();
                unpauseEvent.Invoke();

            }

        }
    }

    void PauseGame ()
    {

        Time.timeScale = 0;

    }

    void UnpauseGame()
    {

        Time.timeScale = 1;

    }

}
