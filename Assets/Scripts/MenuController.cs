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
        /*
        if (SceneManager.GetActiveScene().name == "Emil Scene")
            MenuMusic.instance.GetComponent<AudioSource>().Pause();  This code right here paused the music when the scene.name specified loads in */
      

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                isPaused = true;
                pauseMenu.SetActive(true); // When  pausmenu/ Canvas game object is activated
                Time.timeScale = 0f;// Game frezees and stops time
                AudioListener.pause = true; // Audio stops
            }
        }
    }

    public void ResumeGame() // When game is unfrezed deactivate
    {
        isPaused = false; 
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;

    }

     public void ReturnToMain() 
    {
        SceneManager.LoadScene(MainMenu); // When loading in the scene MainMenu keep the time running in the scene.
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }
}
