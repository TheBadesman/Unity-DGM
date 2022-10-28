using UnityEngine;

public class moveForward : MonoBehaviour
{

    //floats for later use

    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Moves gameobject forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
