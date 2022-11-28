using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject playerBullet;
    public Transform spawnPoints1;
    public Transform spawnPoints2;
    public float bulletSpawnTime = 1f;
    public AudioSource audioSource;

    void Start()
    {
        /*StartCoroutine(Shoot());*/
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(playerBullet, spawnPoints1.position, Quaternion.identity);
            Instantiate(playerBullet, spawnPoints2.position, Quaternion.identity);
            audioSource.Play();
        }
    }
    void Fire()
    {
        /*Instantiate(playerBullet, spawnPoints1.position, Quaternion.identity);
        Instantiate(playerBullet, spawnPoints2.position, Quaternion.identity);*/
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(bulletSpawnTime);
            Fire();
            audioSource.Play();
        }
    }
}
