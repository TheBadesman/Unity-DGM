using UnityEngine;

public class powerUpPickup : MonoBehaviour
{
    //Sets up the floats for later use
    public float speed;

    public bool hasIncreasedFire = false;

    //Moves the power up
    void Update()
    {
        
        transform.Translate(-Vector3.forward * Time.deltaTime * speed);

    }
    //destruction of the power up and log to show its working
    private void OnTriggerEnter(Collider Player)
    {

        Destroy(gameObject);

        Debug.Log("Player has the increased fire powerup");

        public bool hasIncreasedFire = true;

    }
}
