using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In Seconds")] [SerializeField] float levelLoadDelay = 2f;
    [Tooltip("FX particle prefab on ship")] [SerializeField] GameObject deathFx;
    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFx.SetActive(true);
        Invoke("ReloadScene",levelLoadDelay);
    }

    void StartDeathSequence()
    {  
        SendMessage("OnPlayerDeath");
    }

    private void ReloadScene() // string referenced
    {
        SceneManager.LoadScene(1);
    }
}
