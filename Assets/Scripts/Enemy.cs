using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform spawnPointsEnemy1;
    public Transform spawnPointsEnemy2;
    public GameObject enemyBullet;
    public float enemyBulletSpawnTime = 0.5f;
    public float speed = 1f;

    void Start()
    {
        StartCoroutine(EnemyShooting());
    }


    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerBullet")
        {
            Destroy(gameObject);
        }
    }

    void EnemyFire()
    {
        Instantiate(enemyBullet, spawnPointsEnemy1.position, Quaternion.identity);
        Instantiate(enemyBullet, spawnPointsEnemy2.position, Quaternion.identity);

    }
    IEnumerator EnemyShooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(enemyBulletSpawnTime);
            EnemyFire();
        }
    }
}
