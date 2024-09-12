using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTarget : MonoBehaviour
{
    public int sceneOne;

    private void OnMouseExit()
    {
        //Lose
        SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
    }
}
