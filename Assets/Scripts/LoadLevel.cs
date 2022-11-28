using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    int currentIndex;


    void Start()
    {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
    }


    void Update()
    {
        
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(currentIndex+1);
    }

    public void Reload()
    {
        SceneManager.LoadScene(currentIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
