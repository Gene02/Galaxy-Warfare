using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    public Rigidbody2D player;

    
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>(); 
    }

    
    void FixedUpdate()
    {
        MovePlayer();

        LimitarMovimiento();
    }
    
    public void MovePlayer()
    {
        player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
    }

    void LimitarMovimiento()
    {
        Vector2 posicionLimitada = transform.position;

        posicionLimitada.x = Mathf.Clamp(posicionLimitada.x, -1.9f, 1.12f);
        posicionLimitada.y = Mathf.Clamp(posicionLimitada.y, -0.006f, 6.15f);

        transform.position = posicionLimitada;
    }

}
