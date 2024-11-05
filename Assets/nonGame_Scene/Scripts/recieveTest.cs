using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class recieveTest : MonoBehaviour
{
    private void Start()
    {
        gameStat.IInstnace.lifeVal = 3;
    }
    private void Update()
    {
        if (Input.GetKeyUp("r"))
        {
            int num = Random.Range(3, 6);
            SceneManager.LoadScene(num, LoadSceneMode.Single);
        }
    }
}
