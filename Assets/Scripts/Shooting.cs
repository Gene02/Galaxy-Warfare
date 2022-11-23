using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject playerBullet;
    public Transform spawnPoints1;
    public Transform spawnPoints2;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(playerBullet, transform.position, Quaternion.identity);
        }
    }
}
