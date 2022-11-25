using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
   [SerializeField] string ChoseLevel;
   [SerializeField] string BackToMenu;


    public void StartGame()
    {
        SceneManager.LoadScene(ChoseLevel);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game");
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene(BackToMenu);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }

}
