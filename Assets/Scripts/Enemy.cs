using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform spawnPointsEnemy1;
    public Transform spawnPointsEnemy2;
    public GameObject enemyBullet;
    public float enemyBulletSpawnTime = 0.5f;
    public GameObject explosionEnemigo;
    public Healthbar healthbar;
    public float speed = 1f;
    public float health = 10f;

    float barSize = 1f;
    float damage = 0;

    void Start()
    {
        StartCoroutine(EnemyShooting());
        damage = barSize / health;
    }


    void Update()
    {
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerBullet")
        {
            DamageHealthbar();
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                Destroy(gameObject);
                Instantiate(explosionEnemigo, transform.position, Quaternion.identity);
            }
        }
    }

    void DamageHealthbar()
    {
        if (health > 0)
        {
            health -= 1;
            barSize = barSize - damage;
            healthbar.SetSize(barSize);
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
