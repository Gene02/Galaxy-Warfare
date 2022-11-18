using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D enemy;

    public float moveSpeed = 2f;

    public bool changeDirection = false;


    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveEnemy();
    }

    public void moveEnemy()
    {
        if(changeDirection == true)
        {
            enemy.velocity = new Vector2(1, 0) * -1 * moveSpeed;
        }
        else if(changeDirection == false)
        {
            enemy.velocity = new Vector2(1, 0) * moveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RightWall")
        {
            Debug.Log("Hit the right wall");
            changeDirection = true;
        }

        if(collision.gameObject.name == "LeftWall")
        {
            Debug.Log("Hit the left wall");
            changeDirection = false;
        }

    }



}
