using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class Main_Menu_UI : MonoBehaviour
{

    public TMP_InputField TMP_IF;
    public string text;
    
   
    

    

    public void PlayGame()
    {
       NameField.playernamestr = TMP_IF.text;
        SceneManager.LoadScene("Game 2");
    }

    public void Highscore()
    {
        SceneManager.LoadScene("HighScore");

    }

    public void QuitGame()
    {
        Debug.Log("Quit"); 
        Application.Quit();
    }

   
}
