using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    public Transform bar;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void SetSize(float size)
    {
        bar.localScale = new Vector2(size, 1f);
    }
}
