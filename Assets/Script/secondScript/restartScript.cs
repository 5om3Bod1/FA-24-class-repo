using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScript : MonoBehaviour
{
    public int num;
    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            SceneManager.LoadScene(num, LoadSceneMode.Single);
        }
    }
}
