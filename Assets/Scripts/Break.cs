using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public bool Asteroide1;

    public GameObject Asteroide2Prefab;
    
    void Collision()
    {
        if (Asteroide1)
        {
            Instantiate(Asteroide2Prefab, transform.position, Quaternion.identity);
            Instantiate(Asteroide2Prefab, transform.position, Quaternion.identity);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
