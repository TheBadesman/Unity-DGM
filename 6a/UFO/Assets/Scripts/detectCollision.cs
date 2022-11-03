using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    //Code to destory the bolt and the UFO
    public void OnTriggerEnter(Collider other)
    {
        
        Destroy(gameObject);

        Destroy(other.gameObject);

    }

}
