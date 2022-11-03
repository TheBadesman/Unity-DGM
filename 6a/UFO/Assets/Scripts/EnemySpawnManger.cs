using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManger : MonoBehaviour
{
    private float spawnRangeX = 14f;
    private float spawnPosZ = 20f;

    //Array to store UFO ships
    public GameObject[] ufoPrefabs;

    private void Update()
    {
        //Creates Ufos and spawns them when you press S, also choices a random ufo to create
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

            int ufoIndex = Random.Range(0, ufoPrefabs.Length);

            Instantiate(ufoPrefabs[ufoIndex],spawnPOs, ufoPrefabs[ufoIndex].transform.rotation);
        }

    }

}
