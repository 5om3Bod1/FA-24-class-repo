using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryScript : MonoBehaviour
{
    public int game;
    public int start;
    public GameObject slideData;

    private void Awake()
    {
        slideData = GameObject.Find("sliderData");
    }
    private void Update()
    {
        if (Input.GetKeyUp("1"))
        {
            SceneManager.LoadScene(game, LoadSceneMode.Single);
        }
        else if (Input.GetKeyUp("2"))
        {
            Destroy(slideData);
            SceneManager.LoadScene(start, LoadSceneMode.Single);
        }
    }
}
