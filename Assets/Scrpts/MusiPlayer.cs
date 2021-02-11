using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusiPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<MusiPlayer>().Length;
        if (numMusicPlayer > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }
   
}
