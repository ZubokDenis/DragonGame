using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
    public void MenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
