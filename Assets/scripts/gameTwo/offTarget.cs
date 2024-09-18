using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class offTarget : MonoBehaviour
{
    public int count;
    public int sceneOne;


    private void OnMouseOver()
    {
        Invoke("plus", .5f);
    }
    private void OnMouseEnter()
    {
        //Lose
        SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
    }
    private void Update()
    {
        if (count > 5)
        {
            //Lose
            SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
        }
    }
    void plus()
    {
        count++;
    }
}
