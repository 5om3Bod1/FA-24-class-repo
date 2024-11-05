using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver_Three : MonoBehaviour
{
    private void Start()
    {
        Invoke("sceneSwap", 15f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            int num = 1;
            gameStat.IInstnace.lifeVal--;
            SceneManager.LoadScene(num, LoadSceneMode.Single);
        }
    }
    void sceneSwap()
    {
        int num = 1;
        SceneManager.LoadScene(num, LoadSceneMode.Single);
    }
}
