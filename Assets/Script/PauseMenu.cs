using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu;
    public bool gameIsPaused;
    private PlayerMovement PlayerMovement;
    public ObstacleCollision ObstacleCollision;
    public float restartDelay;
    public GameObject Restartt;
    private void Start()
    {
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void resume()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Pause()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("UI");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
