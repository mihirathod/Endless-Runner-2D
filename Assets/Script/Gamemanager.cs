using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public GameObject[] Obstacles;
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 2, 3.0f);

       
    }
    void Update()
    {

    }
    public void SpawnObstacle()
    {
        int Obstacleindex = Random.Range(0, Obstacles.Length);
        Vector3 spwnpos = new Vector3(100, -6.0f, 0);
        Instantiate(Obstacles[Obstacleindex], spwnpos, Obstacles[Obstacleindex].transform.rotation);

    }
    
    bool GameHasEnded = false;
    public float restartDelay;
    public GameObject Restartt;
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", restartDelay);
            RestartMenu();
        }
    }
    public void RestartMenu()
    {
        if (GameHasEnded)
        {
            Restartt.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
}



