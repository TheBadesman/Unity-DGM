using UnityEngine;

public class cameraMovement : MonoBehaviour
{

    public Vector2 turn;

    public float sensitvity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;          
    }

    void Update()
    {

        turn.x += Input.GetAxis("Mouse X") * sensitvity;

        turn.y += Input.GetAxis("Mouse Y") * sensitvity;

        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);


    }
}
