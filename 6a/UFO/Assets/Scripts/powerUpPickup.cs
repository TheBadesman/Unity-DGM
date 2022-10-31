using UnityEngine;
using System.Collections;

public class powerUpPickup : MonoBehaviour
{
    //Sets up the floats for later use
    public float speed;

    public bool HasIncreaseFire;

    public bool hasIncreaseFire
    {
         get {return HasIncreaseFire; }
    }

    //Moves the power up
    void Update()
    {
        
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
