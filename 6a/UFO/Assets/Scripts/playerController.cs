using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameManager gameManager;

    //set up for the blaster and lazer

    public Transform blaster;

    public GameObject laser;

    //setting up the float for later work

    public float horizontalMovement;

    public float speed = 10;

    public float xRange = 23;
    //reference to game manager object
    void Start()
    {

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Player movement script, updates every frame
    void Update()
    {
        //sets horizontalMovement to the right and left axis key inputs
        horizontalMovement = Input.GetAxis("Horizontal");
        //moves your player object
        transform.Translate(Vector3.right * horizontalMovement * Time.deltaTime * speed);
        //teleports player over to the oppisite side (Right)
        if (transform.position.x < -xRange)
        {
            
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);

        }
        //teleports player over to the oppisite side (Left)
        if (transform.position.x > xRange)
        {
            
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            //creating the laser at blasters pos, maintains objects rotation, and stops the spawn of the bolts
            Instantiate(laser, blaster.transform.position, laser.transform.rotation);
        }

    }

    public void OnDestroy()
    {
        gameManager.isGameOver = true;
    }
    // Deleting objects with triggers that hit the player
    private void OnCollisionEnter(Collision PowerUp)
    {
        
        Destroy(PowerUp.gameObject);

    }
}