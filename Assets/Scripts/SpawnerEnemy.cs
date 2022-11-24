using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public GameObject[] enemy;
    public float respawnTime = 2f;
    
    void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    
    void Update()
    {
        
    }

    IEnumerator EnemySpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }

        
    }

    void SpawnEnemy()
    {
        int randomValue = Random.Range(0, enemy.Length);
        int randomXPos = Random.Range(-3, 3);
        Instantiate(enemy[randomValue], new Vector2(randomXPos, transform.position.y), Quaternion.identity);
    }
}
