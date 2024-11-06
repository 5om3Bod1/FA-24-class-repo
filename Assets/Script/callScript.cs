using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class callScript : MonoBehaviour
{
    public int sceneOne;

    private void Update()
    {
        if (Input.GetKeyUp("q"))
        {
            doorCondition.IInstnace.roomGenerator();
        }
        /*if (Input.GetKeyUp("r"))
        {
           SceneManager.LoadScene(sceneOne, LoadSceneMode.Single);
        }
        */
    }
}
