using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform [] spawnPoints;
    public float spawnInterval = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        if (enemyPrefabs.Length == 0) return;
        
        int randomEnemyIndex = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyPrefab = enemyPrefabs[randomEnemyIndex];   
        
        int randomPointIndex = Random.Range(0, spawnPoints.Length);
        Transform selectedSpwanPoint = spawnPoints[randomPointIndex];
        

        GameObject enemy = Instantiate(enemyPrefab, selectedSpwanPoint.position, selectedSpwanPoint.rotation);
    }
}
