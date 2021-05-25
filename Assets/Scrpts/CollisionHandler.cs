using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In Seconds")] [SerializeField] float levelLoadDelay = 2f;
    [Tooltip("FX particle prefab on ship")] [SerializeField] GameObject deathFx;

    
    public GameObject GameOverUI;
    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFx.SetActive(true);
        Invoke("gameOverActive", levelLoadDelay);
        
    }

    public void gameOverActive()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;

    }

    //Invoke("ReloadScene", levelLoadDelay);
    void StartDeathSequence()
    {  
        SendMessage("OnPlayerDeath");
    }

    public void ReloadScene() // string referenced
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Debug.Log("quitting game//////////");
        Application.Quit();
    }
}
