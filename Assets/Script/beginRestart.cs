using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beginRestart : MonoBehaviour
{
    public bool cover;
    public int sceneNum;

    public GameObject text;
    private void Start()
    {
        Invoke("show", 3f);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if (cover)
            {
                SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
            }
        }
        else if (Input.GetKeyDown("r"))
        {
            if (!cover)
            {
                SceneManager.LoadScene(sceneNum, LoadSceneMode.Single);
            }
        }
    }
    void show()
    {
        text.SetActive(true);
    }
}
