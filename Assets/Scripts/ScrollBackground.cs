using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private float moveSpeed = -1.5f;
    [SerializeField] private bool moveStopScrolling;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0, moveSpeed);
    }

    
    void Update()
    {
        if (moveStopScrolling)
        {
            rigidbody.velocity = Vector2.zero;
        }
        else
        {
            rigidbody.velocity = new Vector2(0, moveSpeed);
        }
    }
}
