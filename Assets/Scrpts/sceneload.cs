using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneload : MonoBehaviour
{
    void Start()
    {

        Invoke("LoadFirstScene", 2f);
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Player collided with something");
    }

    void OnTriggerEnter(Collider other)
    {
        print("Player triggered sth");
    }

    void LoadFirstScene()
    {

        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}