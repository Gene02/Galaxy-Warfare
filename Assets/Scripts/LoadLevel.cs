using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void Reload()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
