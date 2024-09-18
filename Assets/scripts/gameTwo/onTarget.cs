using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTarget : MonoBehaviour
{
    public int count;
    public int sceneOne;

    private void Start()
    {
        Invoke("plus", 1f);
        Invoke("plus", 2f);
        Invoke("plus", 3f);
        Invoke("plus", 4f);
    }
    private void OnMouseOver()
    {
        count--;
    }
    private void OnMouseExit()
    {
        //Lose
        SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
    }
    private void Update()
    {
        if (count > 5)
        {
            SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
        }

    }
    void plus()
    {
        count++;
    }
}
