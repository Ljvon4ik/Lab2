using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 16f;
    private float xSpawn = 7f;
    private float zSpawnUpPowerup = 10f;
    private float zSpawnDownPowerup = 1f;
    private float ySpawn = 0.75f;

    private float enemySpawnTime = 1f;
    private float powerupSpawnTime = 5f;
    private float startDelayTime = 1f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelayTime, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelayTime, powerupSpawnTime);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawn, xSpawn);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);
        int indexEnemy = Random.Range(0, enemies.Length);

        Instantiate(enemies[indexEnemy], spawnPos, enemies[indexEnemy].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawn, xSpawn);
        float randomZ = Random.Range(zSpawnDownPowerup, zSpawnUpPowerup);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(powerup, spawnPos, powerup.transform.rotation);
    }
}
