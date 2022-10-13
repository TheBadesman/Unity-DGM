using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    public void Update()
    {
        
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed, 0, Input.GetAxisRaw("Vertical") * speed);

    }
}
