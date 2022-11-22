using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    public float padding = 0.8f;
    float minX;
    float maxX;
    float minY;
    float maxY;

   
    void Start()
    {
        FindBoundaries();
    }

    
    void FindBoundaries()
    {
        Camera gameCamera = Camera.main;
        minX = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        maxX = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        minY = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        minY = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        float newXpos = Mathf.Clamp(transform.position.x + deltaX, minX, maxX);
        float newYpos = Mathf.Clamp(transform.position.y + deltaY, minY, maxX);

        transform.position = new Vector2(newXpos, newYpos);
    }
}
