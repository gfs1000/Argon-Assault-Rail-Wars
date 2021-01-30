using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
public class MusiPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        
        Invoke("LoadFirstScene", 2f);
    }

    void LoadFirstScene()
    {
        
        SceneManager.LoadScene(1);
    }
}
