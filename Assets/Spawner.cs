using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public int minAxis = -20;
    public int maxAxis = 30;

    public int currentEnemyCount;
    public int maxEnemyCount = 5;
    
    private void Update()
    {
        currentEnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (currentEnemyCount < maxEnemyCount)
        {
            SpawnEnemy();
        }
    }

     Vector3 RandomSpawnPointPosition()
    {
        int randomX = Random.Range(minAxis, maxAxis);
        int randomZ = Random.Range(minAxis, maxAxis);

        return new Vector3(randomX, 1f, randomZ);
    }

    void SpawnEnemy()
    {
        transform.position = RandomSpawnPointPosition();

        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
