using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private BoxCollider2D movebackgroundCollider;
    private float moveBackgroundSize;
   
    void Start()
    {
        movebackgroundCollider = GetComponent<BoxCollider2D>();
        moveBackgroundSize = movebackgroundCollider.size.y;
    }

    
    void Update()
    {
        if(transform.position.y < moveBackgroundSize)
        {
            RepeatingBackground();
        }
    }

    void RepeatingBackground()
    {
        Vector2 BGoffset = new Vector2(0, moveBackgroundSize * 1f);
        transform.position = (Vector2)transform.position + BGoffset;
    }
}
