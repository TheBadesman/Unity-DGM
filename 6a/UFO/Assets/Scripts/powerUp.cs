using UnityEngine;
using System.Collections;

public class powerUp : MonoBehaviour
{
    //set up to increase the life
    public LifeManager lifeManager;

    public int LifeToChange;

    //Sets the delay for the color change, and sets the colors
    [Range(0,10)]
    public float colorChangeDelay = 1;
    
    public Color startColor = Color.yellow;

    public Color endColor = Color.red;

    //Sets up the floats for later use
    public float speed;

    public bool HasIncreaseLife;

    public bool hasIncreaseLife
    {
         get {return HasIncreaseLife; }
    }

    Renderer powerUpColor;
    //Calls the life manager
    public void Start()
    {

    lifeManager = GameObject.Find("LifeManager").GetComponent<LifeManager>();

    }

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

            Debug.Log("Has increased life");

            HasIncreaseLife = true;

            lifeManager.IncreaseLives(LifeToChange);

            if (HasIncreaseLife == true)
            {

                Debug.Log("Check for Inventory");

            }

        }

    }
}
