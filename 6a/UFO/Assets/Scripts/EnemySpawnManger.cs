using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManger : MonoBehaviour
{
    //Array to store UFO ships
    public GameObject[] ufoPrefabs;

    public int ufoIndex;

    private void Update()
    {
        //Creates Ufos and spawns them when you press S
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(ufoPrefabs[ufoIndex],new Vector3(0,0,20), ufoPrefabs[ufoIndex].transform.rotation);
        }

    }

}
