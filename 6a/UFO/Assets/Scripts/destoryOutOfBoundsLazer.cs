using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryOutOfBoundsLazer : MonoBehaviour
{

    //Public floats for later
    public float upperBounds = 30.0f;

    public float lowerBounds = -10.0f;

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
