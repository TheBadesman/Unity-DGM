using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryOutOfBounds : MonoBehaviour
{

    //Public floats for later
    public float upperBounds = 50.0f;

    public float lowerBounds = -20.0f;

    private void Awake()
    {
        
        //Time.timeScale = 1;

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
            //Time.timeScale = 0;

        }

    }
}
