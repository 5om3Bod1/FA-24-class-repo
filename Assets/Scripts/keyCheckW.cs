using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyCheckW : MonoBehaviour
{
    public GameObject bonk1;
    public GameObject bonk2;
    public int sceneNum;

    void Update()
    {
        if (Input.GetKeyUp("w"))
        {
            Invoke("keyW", .5f);
            Invoke("restart", 1.25f);
            
        }
        else if (Input.GetKeyUp("s"))
        {
            Invoke("keyS",.5f);
            Invoke("restart", 1.25f);
        }
    }
    void keyW()
    {
        bonk1.SetActive(true);
        
    }
    void keyS()
    {
        bonk2.SetActive(true);
    }
    void restart()
    {
        SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
    }
}
