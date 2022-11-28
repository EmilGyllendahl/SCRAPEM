using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


 public class MenuController : MonoBehaviour
 {
   
    public string MainMenu;
    public GameObject pauseMenu;
    public bool isPaused;



     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
                AudioListener.pause = true;
            }
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }

     public void ReturnToMain()
    {
        SceneManager.LoadScene(MainMenu);
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }
 }
