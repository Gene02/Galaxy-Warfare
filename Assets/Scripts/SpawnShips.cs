using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour
{
    [SerializeField] GameObject[] asteroidPrefab;

    [SerializeField] float secondSpawn = 0.2f;

    [SerializeField] float minTras;

    [SerializeField] float maxTras;

    public float Speed = 2f;

    void Start()
    {
        StartCoroutine(AsteroidSpawn());
    }

    
    IEnumerator AsteroidSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(asteroidPrefab[Random.Range(0, asteroidPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
