using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //public void PlayGame()
    //{
    //    SceneManager.LoadScene("Game");
    //}

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void PausedGame(bool Paused)
    {
        if (!Paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    //open url method
    public void OpenURL(string URLName)
    {
        Application.OpenURL(URLName);
    }

    //open author
    public void OpenAuthor()
    {
        Debug.Log("Created by UkiAula");
    }

    //for quit aplication
    public void QuitApplication()
    {
        print("quiiit bukan quiet");
        Application.Quit();
    }
}
