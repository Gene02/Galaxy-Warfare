using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPosition;
    
    void Start()
    {
        StartPosition = transform.position;
    }

    
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -9.38f)
        {
            transform.position = StartPosition;
        }
    }
}
