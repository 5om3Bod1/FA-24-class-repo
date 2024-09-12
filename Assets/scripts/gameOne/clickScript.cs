using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickScript : MonoBehaviour
{
    public int sceneOne;

    private void OnMouseEnter()
    {
        //Lose
        SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
    }
}
