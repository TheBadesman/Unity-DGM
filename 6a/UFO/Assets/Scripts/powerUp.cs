using UnityEngine;
using System.Collections;

public class powerUp : MonoBehaviour
{
    //Sets the delay for the color change, and sets the colors
    [Range(0,10)]
    public float colorChangeDelay = 1;
    
    public Color startColor = Color.yellow;

    public Color endColor = Color.red;

    //Sets spawn delay, and delay before the second spawn
    public float powerUpSpawnDelay = 15f;

    //Sets up the floats for later use
    public float speed;

    public bool HasIncreaseFire;

    public bool hasIncreaseFire
    {
         get {return HasIncreaseFire; }
    }

    Renderer powerUpColor;

    //gets the component we want to change
    private void Awake()
    {

        powerUpColor = GetComponent<Renderer>();

    }

    //Moves the power up
    void Update()
    {

        powerUpColor.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * colorChangeDelay, 1));

        transform.Translate(-Vector3.forward * Time.deltaTime * speed);

    }
    //destruction of the power up and log to show its working
    private void OnTriggerEnter(Collider other)
    {
        // checks the tag, if it collided with play tells it that the player now has the power up and prints that in the Debug
        if (other.gameObject.tag == "Player")
        {

            Destroy(gameObject);

            Debug.Log("Player has the increased fire powerup");

            HasIncreaseFire = true;

            if (HasIncreaseFire == true)
            {

                Debug.Log("Check for Inventory");

            }

        }

    }
}
