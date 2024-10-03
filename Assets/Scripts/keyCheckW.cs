using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyCheckW : MonoBehaviour
{
    GameObject bonk;
    public int sceneNum;

    void Update()
    {
        if (Input.GetKeyUp("w"))
        {
            bonk.SetActive(true);
        }
        else if (Input.anyKey)
        {
            SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
        }
    }
}
