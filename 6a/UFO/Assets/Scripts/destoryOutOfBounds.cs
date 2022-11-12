using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryOutOfBounds : MonoBehaviour
{
    public GameManager gameManager;
    //Stuff for Lives
    public LifeManager lifeManager;

    public int LifeToLose;

    //Public floats for later
    public float upperBounds = 50.0f;

    public float lowerBounds = -20.0f;

    //reference to game manager object
    void Start()
    {

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        lifeManager = GameObject.Find("LifeManager").GetComponent<LifeManager>();

    }

    void Update()
    {
        
        if (transform.position.z > upperBounds)
        {
            
            Destroy(gameObject);

        }
        else if(transform.position.z < lowerBounds)
        {
            //destories object and reduces lives
            Destroy(gameObject);
            lifeManager.DecreaseLives(LifeToLose);
            

        }

    }
}
