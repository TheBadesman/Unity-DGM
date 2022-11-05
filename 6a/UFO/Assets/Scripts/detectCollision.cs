using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    //Code to destory the bolt and the UFO
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Bolt")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }

    }

}
