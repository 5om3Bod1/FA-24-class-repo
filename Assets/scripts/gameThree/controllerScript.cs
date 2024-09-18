using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerScript : MonoBehaviour
{
    public int count;
    public GameObject round1;
    public GameObject round2;

    public int sceneTwo;

    private void Start()
    {
        Invoke("cnt", 1f);
        Invoke("cnt", 2f);
        Invoke("cnt", 3f);
        Invoke("cnt", 4f);
        Invoke("cnt", 5f);
        Invoke("cnt", 6f);
        Invoke("swap", 10f);
    }
    void Update()
    {
        if (count == 4)
        {
            round1.SetActive(true);
        }
        if (count == 0)
        {
            round2.SetActive(true);
        }
    }
    void cnt()
    {
        count--;
    }
    void swap()
    {
        //Win
        SceneManager.LoadScene(sceneTwo, LoadSceneMode.Single);
    }
}
