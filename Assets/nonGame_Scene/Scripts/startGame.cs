using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startGame : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            int num = Random.Range(3, 6);
            SceneManager.LoadScene(num, LoadSceneMode.Single);
        }
    }
}
