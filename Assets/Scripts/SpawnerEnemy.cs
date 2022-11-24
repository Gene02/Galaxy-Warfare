using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public GameObject[] enemy;
    
    void Start()
    {
        SpawnEnemy();
    }

    
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        Instantiate(enemy[0], transform.position, Quaternion.identity);
    }
}
