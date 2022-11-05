using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawner : MonoBehaviour
{
    //The ranges between the spawns
    private float spawnRangeX = 14f;

    private float spawnPosZ = 20f;

    //Sets spawn delay, and delay before the second spawn
    public float powerUpSpawnDelay = 15f;

    public float powerUpSpawnTimer = 15f;

    public GameObject PowerUp;


    //sets the repeating spawn of the power up
    private void Start()
    {
        InvokeRepeating("SpawnPowerUp", powerUpSpawnDelay, powerUpSpawnTimer);
    }

    void SpawnPowerUp()
    {
        Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

        Instantiate(PowerUp,spawnPOs, PowerUp.transform.rotation);

    }
}
