using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public GameObject[] enemy;
    public float respawnTime = 2f;
    public int enemySpawnCount = 10;
    public GameController gameController;

    private bool lastEnemySpawned = false;
    
    void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    
    void Update()
    {
        if (lastEnemySpawned && FindObjectOfType<Enemy>() == null)
        {
            gameController.LevelComplete();
        }
    }

    IEnumerator EnemySpawner()
    {
        for (int i = 0; i < enemySpawnCount; i++)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
        lastEnemySpawned = true;

        
    }

    void SpawnEnemy()
    {
        int randomValue = Random.Range(0, enemy.Length);
        int randomXPos = Random.Range(-3, 3);
        Instantiate(enemy[randomValue], new Vector2(randomXPos, transform.position.y), Quaternion.identity);
    }
}
