using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryOutOfBounds : MonoBehaviour
{
    public GameManager gameManager;

    //Public floats for later
    public float upperBounds = 50.0f;

    public float lowerBounds = -20.0f;

    //reference to game manager object
    void Start()
    {

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    void Update()
    {
        
        if (transform.position.z > upperBounds)
        {
            
            Destroy(gameObject);

        }
        else if(transform.position.z < lowerBounds)
        {

            Destroy(gameObject);
            gameManager.isGameOver = true;

        }

    }
}
