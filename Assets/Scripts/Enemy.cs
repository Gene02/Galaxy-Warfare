using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public Transform []spawnPointsEnemy;
    
    public GameObject enemyBullet;
    public float enemyBulletSpawnTime = 0.5f;
   
    public Healthbar healthbar;
    public float speed = 1f;
    public float health = 10f;
    public GameObject explosionEnemigo;
    public GameObject flash;
    public GameObject coinPrefab;

    public AudioClip bulletSound;
    public AudioClip damageSound;
    public AudioClip explosionSound;
    public AudioSource audioSource;

    

    float barSize = 1f;
    float damage = 0;

    void Start()
    {
        flash.SetActive(false);
        StartCoroutine(EnemyShooting());
        damage = barSize / health;
    }


    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerBullet")
        {
            Score1.scoreValue += 5;
            audioSource.PlayOneShot(damageSound);
            DamageHealthbar();
            Destroy(collision.gameObject);
            if (health <= 0)
            
            {
                AudioSource.PlayClipAtPoint(explosionSound, Camera.main.transform.position, 0.5f);
                /*Instantiate(coinPrefab, transform.position, Quaternion.identity);*/
                Destroy(gameObject);
                explosionEnemigo = Instantiate(explosionEnemigo, transform.position, Quaternion.identity);
                Destroy(explosionEnemigo,0.4f);
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
        for(int i = 0; i < spawnPointsEnemy.Length; i++)
        {
            Instantiate(enemyBullet, spawnPointsEnemy[i].position, Quaternion.identity);
        }

        //Instantiate(enemyBullet, spawnPointsEnemy1.position, Quaternion.identity);
        //Instantiate(enemyBullet, spawnPointsEnemy2.position, Quaternion.identity);

    }
    IEnumerator EnemyShooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(enemyBulletSpawnTime);
            EnemyFire();
            audioSource.PlayOneShot(bulletSound, 0.5f);
            flash.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            flash.SetActive(false);
        }
    }
}
