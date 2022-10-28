using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetup : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene("Main");
    }
    public void ExittoMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GoToGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void GoToAbout()
    {
        SceneManager.LoadScene("About");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
