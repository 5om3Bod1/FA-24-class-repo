using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winScript : MonoBehaviour
{
    public GameObject bounds;
    public int sceneOne;
    public int sceneTwo;

    private void Start()
    {
        Invoke("remove", 1f);
        Invoke("swap", 11f);
    }

    private void remove()
    {
        bounds.SetActive(false);
    }
    private void swap()
    {
        //Lose
        SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
    }
    private void OnMouseEnter()
    {
        //Win
        SceneManager.LoadScene(sceneTwo, LoadSceneMode.Single);
    }
}
