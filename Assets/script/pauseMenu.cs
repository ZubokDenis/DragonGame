using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public bool pauseGame;
    public GameObject pausePanel;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseGame) 
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
  }



    public void Pause()
    {
        pausePanel.SetActive(true);
        pauseGame = true;
        Time.timeScale = 0f;

    }
    public void Resume()
    {
        pausePanel.SetActive(false);
        pauseGame = false;
        Time.timeScale = 1f;
    }
    public void LoadMemu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }






}
