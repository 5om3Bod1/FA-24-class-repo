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
        count++;
    }
    private void OnMouseEnter()
    {
        //Lose
        SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
    }
    private void Update()
    {
        if(count > 200)
        {
            //Lose
            SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
        }
    }
}
