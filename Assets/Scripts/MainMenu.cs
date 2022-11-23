using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
   [SerializeField] string ChoseLevel;


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


}
