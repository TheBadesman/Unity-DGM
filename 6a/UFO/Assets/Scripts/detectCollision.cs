using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    public GameManager gameManager;

    //calls the score manager and references the manager
    public ScoreManager scoreManager;
    //Calls the life manager and creates the amount of life to be lost
    public LifeManager lifeManager;

    public int LifeToLose;

    public int scoreToGive;

    void Start()
    {
        //finds and references the score manager, Game manager, and Life manager
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        lifeManager = GameObject.Find("LifeManager").GetComponent<LifeManager>();

    }

    //Code to destory the bolt and the UFO
    public void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            lifeManager.DecreaseLives(LifeToLose);

        }

        if (other.gameObject.tag == "Bolt")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }

    }

}
