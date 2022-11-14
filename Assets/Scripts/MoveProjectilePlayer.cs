using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectilePlayer : MonoBehaviour
{

    public Rigidbody2D projectile;

    public float moveSpeed = 10.0f;

    public float limite;
    
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(transform.position.y >= limite)
        {
            gameObject.SetActive(false);
        }
    }

    
    void Update()
    {
        projectile.velocity = new Vector2(0, 1) * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Enemy")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
