using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    public GameManager gameManager;

    //calls the score manager and references the manager
    public ScoreManager scoreManager;

    public int scoreToGive;

    void Start()
    {
        //finds and references the score manager
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    //Code to destory the bolt and the UFO
    public void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Bolt")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }

    }

}