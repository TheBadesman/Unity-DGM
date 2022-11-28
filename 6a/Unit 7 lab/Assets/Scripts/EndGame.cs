using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public void EndsGame()
    {

        Application.Quit();

    }

    public void EndGameFreeze()
    {

        Time.timeScale = 0;

    }

}
