using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManger : MonoBehaviour
{
    //The ranges between the spawns
    private float spawnRangeX = 14f;

    private float spawnPosZ = 20f;

    //The delays for the spawns
    private float startDelay = 2f;

    private float spawnInterval = 1.5f;

    //Array to store UFO ships
    public GameObject[] ufoPrefabs;

    private void Start()
    {
        
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);

    }

    private void Update()
    {
 

    }
    //The spawn code for the UFOs
    void SpawnRandomUFO()
    {

        Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

        int ufoIndex = Random.Range(0, ufoPrefabs.Length);

        Instantiate(ufoPrefabs[ufoIndex],spawnPOs, ufoPrefabs[ufoIndex].transform.rotation);

    }

}
