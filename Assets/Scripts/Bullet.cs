using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocidadBala;
    public float limite;



    void FixedUpdate()
    {
        transform.Translate(Vector2.up * velocidadBala);

        if(transform.position.y >= limite)
        {
            gameObject.SetActive(false);
        }
    }
    
}
