using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Renderer meshRender;
    public float speed = 0.1f;


    void Start()
    {

    }


    void Update()
    {
        Vector2 offset = meshRender.material.mainTextureOffset;
        offset = offset + new Vector2(0, speed * Time.deltaTime);
        meshRender.material.mainTextureOffset = offset;
    }
}
