using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour
{
    public GameObject[] objetosParaSpawnear;

    public Transform[] puntosdeSpawn;

    public float tiempoMaximoEntreDosSpawn;

    public float tiempoActualDosSpawn;

    void Start()
    {
        tiempoActualDosSpawn = tiempoMaximoEntreDosSpawn;
    }

    
    void Update()
    {
        tiempoActualDosSpawn -= Time.deltaTime;

        if(tiempoActualDosSpawn <= 0)
        {
            SpawnearObjeto();
        }
    }

    private void SpawnearObjeto()
    {
        int objetoAleatorio = Random.Range(0, objetosParaSpawnear.Length);
        int puntoAleatorio = Random.Range(0, puntosdeSpawn.Length);

        Instantiate(objetosParaSpawnear[objetoAleatorio], puntosdeSpawn[puntoAleatorio].position, Quaternion.Euler(0f, 0f, -180f));
        tiempoActualDosSpawn = tiempoMaximoEntreDosSpawn;
    }
}
