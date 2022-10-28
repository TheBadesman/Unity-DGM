using UnityEngine;

public class playerController : MonoBehaviour
{

    //setting up the float for later work

    public float horizontalMovement;

    public float speed;

    // Player movement script, updates every frame
    void Update()
    {
        //sets horizontalMovement to the right and left axis key inputs
        horizontalMovement = Input.GetAxis("Horizontal");
        //moves your player object
        transform.Translate(Vector3.right * horizontalMovement * Time.deltaTime * speed);

    }
}