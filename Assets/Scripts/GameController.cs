using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public GameObject GameOverPanel;
    public GameObject levelCompletePanel;

    void Start()
    {
        Time.timeScale = 1f;
        levelCompletePanel.SetActive(false);
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        GameOverPanel.SetActive(false);
    }

    void Update()
    {

    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void LevelComplete()
    {
        Time.timeScale = 0f;
        levelCompletePanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
