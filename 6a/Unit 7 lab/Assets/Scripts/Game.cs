using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
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
